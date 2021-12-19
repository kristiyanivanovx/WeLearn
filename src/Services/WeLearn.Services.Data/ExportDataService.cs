using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Npgsql;

using WeLearn.Data.Models.Recommendation;

using static WeLearn.Common.GlobalConstants;
using static WeLearn.Services.ML.RecommendationsService;

namespace WeLearn.Services.Data
{
    public class ExportDataService
    {
        public static async Task Main()
        {
            /*
            * users-in-lessons.csv
            * UserId,LessonId
            */

            Console.OutputEncoding = Encoding.UTF8;

            // 1. Export existing data to csv file
            await ExportDataToCsv();

            // 2. Train ML model
            string exportPathLocation = Path.Combine(ExportDirectory, ExportFileName);
            string exportModelPathLocation = Path.Combine(ExportDirectory, ModelFile);
            TrainModel(exportPathLocation, exportModelPathLocation);

            // 3. Change the values here with your data - user ids and lesson ids
            var testModelData = new List<UserInLesson>
                {
                    new UserInLesson { UserId = "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", LessonId = 13 },
                    new UserInLesson { UserId = "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", LessonId = 9 },
                    new UserInLesson { UserId = "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6", LessonId = 7 },

                    new UserInLesson { UserId = "d91316c6-8823-4614-a3c5-6228f06c746a", LessonId = 25 },
                    new UserInLesson { UserId = "d91316c6-8823-4614-a3c5-6228f06c746a", LessonId = 15 },
                };

            // 4. Test model - recommendations
            TestRecommendationsModel(exportModelPathLocation, testModelData);
        }

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

        private static async Task ExportDataToCsv()
        {
            string exportPathLocation = Path.Combine(ExportDirectory, ExportFileName);

            // Stream writer for CSV file.
            StreamWriter csvFile = null;
            NpgsqlDataReader reader = null;

            // Check to see if the file path exists.
            if (Directory.Exists(ExportDirectory))
            {
                try
                {
                    var configuration = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", false, true)
                        .Build();

                    var connectionString = configuration.GetConnectionString("DefaultConnectionPostgreSQL");

                    await using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        NpgsqlCommand command = new NpgsqlCommand(
                            "SELECT \"ApplicationUserId\", \"LessonId\" FROM \"Likes\";",
                            connection);

                        command.CommandType = CommandType.Text;
                        await connection.OpenAsync();

                        reader = await command.ExecuteReaderAsync();
                        csvFile = new StreamWriter(exportPathLocation);

                        string[] outline = new string[reader.FieldCount];

                        await csvFile.WriteLineAsync(string.Join(",", "UserId", "LessonId"));

                        while (await reader.ReadAsync())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                outline[i] = Escape(reader.GetValue(i).ToString());
                            }

                            await csvFile.WriteLineAsync(string.Join(",", outline));
                        }

                        await reader.CloseAsync();
                        csvFile.Close();

                        Console.WriteLine("Data export successful.");
                    }
                }
                finally
                {
                    if (reader != null)
                    {
                        await reader.CloseAsync();
                    }

                    csvFile?.Close();
                }
            }
            else
            {
                Console.WriteLine("File path does not exist.");
            }
        }
    }
}
