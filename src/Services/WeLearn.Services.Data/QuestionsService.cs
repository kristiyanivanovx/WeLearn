using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models.Quiz;
using WeLearn.Services.Data.Interfaces;
using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Question;

namespace WeLearn.Services.Data
{
    public class QuestionsService : IQuestionsService
    {
        private readonly IDeletableEntityRepository<Question> questionRepository;

        public QuestionsService(IDeletableEntityRepository<Question> questionRepository)
            => this.questionRepository = questionRepository;

        public async Task CreateAsync(QuestionInputModel model)
        {
            var question = new Question
            {
                Content = model.Content,
                Points = model.Points,
            };

            await this.questionRepository.AddAsync(question);
            await this.questionRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var question = this.questionRepository
                .All()
                .FirstOrDefault(x => x.Id == id);

            if (question == null)
            {
                // todo: not found
                return;
            }

            this.questionRepository.Delete(question);
            await this.questionRepository.SaveChangesAsync();
        }

        public async Task EditAsync(QuestionEditModel model)
        {
            var entity = this.GetById(model.Id);

            if (entity != null)
            {
                entity.Content = model.Content;
                entity.Points = model.Points;
            }

            await this.questionRepository.SaveChangesAsync();
        }

        public bool Contains(int id)
            => this.questionRepository
                .All()
                .Any(x => x.Id == id);

        public IEnumerable<Question> GetAllWithAnswers()
            => this.questionRepository
                .All()
                .Include(q => q.Answers)
                .ToList();

        public Question GetById(int id)
            => this.questionRepository
                .All()
                .FirstOrDefault(x => x.Id == id);

        public IEnumerable<T> GetAll<T>()
            => this.questionRepository
                .All()
                .Include(x => x.Answers)
                .AsSingleQuery()
                .To<T>()
                .ToList();

        public T GetById<T>(int id)
            => this.questionRepository
                .All()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefault();
    }
}
