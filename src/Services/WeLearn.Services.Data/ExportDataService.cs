using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

using Microsoft.Extensions.Configuration;
using Microsoft.ML;
using Npgsql;
using WeLearn.Common;
using WeLearn.Data.Models.Recommendation;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Services.Data
{
    public class ExportDataService
    {
        public static void Main()
        {
            /*
            * users-in-lessons.csv
            * UserId,LessonId
            */

            Console.OutputEncoding = Encoding.UTF8;

            ExportDataToCsv();
            // TrainModel(path, modelFile);
            
            var testModelData = new List<UserInLesson>
                {
                    new UserInLesson { UserId = "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", LessonId = 13 },
                    new UserInLesson { UserId = "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", LessonId = 9 },
                    new UserInLesson { UserId = "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", LessonId = 7 },

                    new UserInLesson { UserId = "d91316c6-8823-4614-a3c5-6228f06c746a", LessonId = 25 },
                    new UserInLesson { UserId = "d91316c6-8823-4614-a3c5-6228f06c746a", LessonId = 15 },
                };
            
            //TestModel(ModelFile, testModelData);
        }

        private static void TestModel(string outputFile, IEnumerable<UserInLesson> testModelData)
        {
            var context = new MLContext();
            var model = context.Model.Load(outputFile, out _);
            var predictionEngine = context.Model.CreatePredictionEngine<UserInLesson, UserInLessonScore>(model);

            foreach (var testInput in testModelData)
            {
                var prediction = predictionEngine.Predict(testInput);
                Console.WriteLine($"User: {testInput.UserId}, Lesson: {testInput.LessonId}, Score: {prediction.Score}");
            }
        }

        // todo: extract method to Data Manipulation Service
        private static string Escape(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            if (value.Contains(Quote))
            {
                value = value.Replace(Quote, EscapedQuote);
            }

            if (value.IndexOfAny(CharactersThatMustBeQuoted) > -1)
            {
                value = Quote + value + Quote;
            }

            return value;
        }

        private static void ExportDataToCsv()
        {
            // Stream writer for CSV file.  
            StreamWriter csvFile = null;
            NpgsqlDataReader reader = null;

            // Check to see if the file path exists.  
            if (Directory.Exists(ExportPathServices))
            {
                try
                {
                    var configuration = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", false, true)
                        .Build();

                    var connectionString = configuration.GetConnectionString("DefaultConnectionPostgreSQL");

                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        NpgsqlCommand command = new NpgsqlCommand(
                            "SELECT \"ApplicationUserId\", \"LessonId\" FROM \"Likes\";",
                            connection);

                        command.CommandType = CommandType.Text;
                        connection.Open();

                        reader = command.ExecuteReader();
                        string[] outline = new string[reader.FieldCount];

                        csvFile = new StreamWriter(ExportPathServices);
                        csvFile.WriteLine(string.Join(",", "UserId", "LessonId"));

                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                outline[i] = Escape(reader.GetValue(i).ToString());
                            }

                            csvFile.WriteLine(string.Join(",", outline));
                        }

                        // reader.Close();
                        // csvFile.Close();

                        // Message stating export successful.
                        Console.WriteLine("Data export successful.");
                    }
                }
                finally
                {
                    reader?.Close();
                    csvFile?.Close();

                    //File.Copy(GlobalConstants.Path, ExportCsvPath, true);
                }
            }
            else
            {
                // Display a message stating file path does not exist.  
                Console.WriteLine("File path does not exist.");
            }
        }
    }
}
