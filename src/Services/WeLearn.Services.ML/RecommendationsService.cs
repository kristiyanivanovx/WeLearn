using System;
using System.Collections.Generic;

using Microsoft.ML;
using Microsoft.ML.Trainers;

using WeLearn.Data.Models.Recommendation;

namespace WeLearn.Services.ML
{
    public static class RecommendationsService
    {
        public static void TrainModel(string inputFile, string outputFile)
        {
            // Create MLContext to be shared across the model creation workflow objects
            var context = new MLContext();

            // Load data
            IDataView trainingDataView = context.Data.LoadFromTextFile<UserInLesson>(
                inputFile,
                hasHeader: true,
                separatorChar: ',');

            // Build & train model
            IEstimator<ITransformer> estimator = context.Transforms.Conversion
                .MapValueToKey(
                    outputColumnName: "userIdEncoded",
                    inputColumnName: nameof(UserInLesson.UserId))
                .Append(
                    estimator: context.Transforms.Conversion.MapValueToKey(
                        outputColumnName: "lessonIdEncoded",
                        inputColumnName: nameof(UserInLesson.LessonId)));

            var options = new MatrixFactorizationTrainer.Options
            {
                LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass,
                MatrixColumnIndexColumnName = "userIdEncoded",
                MatrixRowIndexColumnName = "lessonIdEncoded",
                LabelColumnName = nameof(UserInLesson.Label),
                Alpha = 0.1,
                Lambda = 0.5,
                NumberOfIterations = 150,
            };

            var trainerEstimator = estimator.Append(context.Recommendation().Trainers.MatrixFactorization(options));
            ITransformer model = trainerEstimator.Fit(trainingDataView);

            // Save model
            context.Model.Save(model, trainingDataView.Schema, outputFile);
        }

        public static void TestRecommendationsModel(string modelFile, IEnumerable<UserInLesson> testModelData)
        {
            var context = new MLContext();
            var model = context.Model.Load(modelFile, out _);
            var predictionEngine = context.Model.CreatePredictionEngine<UserInLesson, UserInLessonScore>(model);

            foreach (var testInput in testModelData)
            {
                var prediction = predictionEngine.Predict(testInput);

                Console.WriteLine(
                    $"User: {testInput.UserId}, Lesson: {testInput.LessonId}, Score: {prediction.Score}");
            }
        }
    }
}
