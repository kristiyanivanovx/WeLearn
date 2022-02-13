using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models.Quiz;
using WeLearn.Services.Data.Interfaces;
using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Quiz;

namespace WeLearn.Services.Data
{
    public class QuizzesService : IQuizzesService
    {
        private readonly IDeletableEntityRepository<Question> questionRepository;
        private readonly IDeletableEntityRepository<Quiz> quizRepository;

        public QuizzesService(
            IDeletableEntityRepository<Question> questionRepository,
            IDeletableEntityRepository<Quiz> quizRepository)
        {
            this.questionRepository = questionRepository;
            this.quizRepository = quizRepository;
        }

        public async Task CreateAsync(QuizInputModel model)
        {
            var quiz = new Quiz
            {
                Name = model.Name,
                CategoryId = model.CategoryId,
            };

            await this.quizRepository.AddAsync(quiz);

            // attach each question to the quiz
            for (int idx = 0; idx < model.QuestionIds.Count(); idx++)
            {
                var questionId = model.QuestionIds.ElementAt(idx);
                var question = this.questionRepository
                    .All()
                    .FirstOrDefault(x => x.Id == questionId);

                quiz.Questions.Add(question);
            }

            await this.quizRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var quiz = this.quizRepository
                .All()
                .FirstOrDefault(x => x.Id == id);

            if (quiz == null)
            {
                // todo: not found
                return;
            }

            this.quizRepository.Delete(quiz);
            await this.quizRepository.SaveChangesAsync();
        }

        public async Task EditAsync(QuizEditModel model)
        {
            var entity = this.GetById(model.Id);

            entity.Name = model.Name;
            entity.CategoryId = model.CategoryId;

            var questions = this.questionRepository
                .All()
                .Where(x => model.QuestionIds != null && model.QuestionIds.Contains(x.Id))
                .ToList();

            entity.Questions
                .Except(questions)
                .ToList()
                .ForEach(x => entity.Questions.Remove(x));

            questions
                .Except(entity.Questions)
                .ToList()
                .ForEach(x => entity.Questions.Add(x));

            this.quizRepository.Update(entity);
            await this.quizRepository.SaveChangesAsync();
        }

        public int GetCount()
            => this.quizRepository
                .All()
                .AsSingleQuery()
                .Count();

        public bool Contains(int id)
            => this.quizRepository
                .All()
                .AsSingleQuery()
                .Any(x => x.Id == id);

        public IEnumerable<T> GetById<T>(int id)
            => this.quizRepository
                .All()
                .Where(x => x.Id == id)
                .Include(x => x.Questions)
                    .ThenInclude(x => x.Answers)
                .AsSingleQuery()
                .To<T>()
                .ToList();

        public IEnumerable<T> GetAll<T>()
            => this.quizRepository
                .All()
                .Include(x => x.Questions)
                    .ThenInclude(x => x.Answers)
                .AsSingleQuery()
                .To<T>()
                .ToList();

        public Quiz GetById(int id)
            => this.quizRepository
                .All()
                .Include(x => x.Questions)
                .AsSingleQuery()
                .FirstOrDefault(x => x.Id == id);
    }
}
