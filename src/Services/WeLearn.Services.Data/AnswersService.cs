using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models.Quiz;
using WeLearn.Services.Data.Interfaces;
using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Answer;

namespace WeLearn.Services.Data
{
    public class AnswersService : IAnswersService
    {
        private readonly IDeletableEntityRepository<Answer> answerRepository;

        public AnswersService(IDeletableEntityRepository<Answer> answerRepository)
            => this.answerRepository = answerRepository;

        public IEnumerable<T> GetAll<T>()
            => this.answerRepository
                .All()
                .To<T>()
                .ToList();

        public bool Contains(int id)
           => this.answerRepository
               .All()
               .Any(x => x.Id == id);

        public T GetById<T>(int id)
            => this.answerRepository
                .All()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefault();

        public async Task<int> CreateAsync(AnswerInputModel model)
        {
            var answer = new Answer
            {
                IsCorrect = model.IsCorrect,
                Content = model.Content,
                QuestionId = model.QuestionId,
            };

            await this.answerRepository.AddAsync(answer);
            return await this.answerRepository.SaveChangesAsync();
        }

        public async Task<int> EditAsync(AnswerEditModel model)
        {
            var entity = this.answerRepository
                .All()
                .FirstOrDefault(x => x.Id == model.Id);

            if (entity != null)
            {
                entity.IsCorrect = model.IsCorrect;
                entity.Content = model.Content;
                entity.QuestionId = model.QuestionId;

                this.answerRepository.Update(entity);
            }

            return await this.answerRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = this.answerRepository
                .All()
                .FirstOrDefault(x => x.Id == id);

            this.answerRepository.Delete(entity);

            await this.answerRepository.SaveChangesAsync();
        }
    }
}
