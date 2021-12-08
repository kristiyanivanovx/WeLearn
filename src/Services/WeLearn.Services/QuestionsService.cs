using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models;
using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Question;

namespace WeLearn.Services
{
    public class QuestionsService
    {
        private readonly IDeletableEntityRepository<Question> questionRepository;

        public QuestionsService(IDeletableEntityRepository<Question> questionRepository)
        {
            this.questionRepository = questionRepository;
        }

        public async Task CreateAsync(QuestionInputModel model)
        {
            var question = new Question
            {
                Content = model.Content,
                Points = model.Points,
            };

            // var question = AutoMapperConfig.MapperInstance.Map<Question>(model);
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
            var entity = this.GetQuestionById(model.Id);

            entity.Content = model.Content;
            entity.Points = model.Points;

            await this.questionRepository.SaveChangesAsync();
        }

        public bool Contains(int id)
            => this.questionRepository
                .All()
                .Any(x => x.Id == id);

        public IEnumerable<T> GetAll<T>()
            => this.questionRepository
                .All()
                .To<T>()
                .ToList();

        public Question GetQuestionById(int id)
            => this.questionRepository
                .All()
                .FirstOrDefault(x => x.Id == id);

        public IEnumerable<T> GetById<T>(int id)
            => this.questionRepository
                .All()
                .Where(x => x.Id == id)
                .To<T>()
                .ToList();
    }
}
