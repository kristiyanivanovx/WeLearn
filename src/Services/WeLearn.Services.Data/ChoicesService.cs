using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models.Quiz;
using WeLearn.Services.Data.Interfaces;

namespace WeLearn.Services.Data
{
    public class ChoicesService : IChoicesService
    {
        private readonly IDeletableEntityRepository<Choice> choicesRepository;

        public ChoicesService(IDeletableEntityRepository<Choice> choicesRepository)
            => this.choicesRepository = choicesRepository;

        public async Task SaveChangesAsync()
            => await this.choicesRepository.SaveChangesAsync();

        public async Task<IEnumerable<Choice>> GetAllAsync()
            => await this.choicesRepository.All().ToListAsync();

        public async Task<Choice> CreateAsync(int questionId, int userAnswerId)
        {
            var choice = new Choice
            {
                QuestionId = questionId,
                UserAnswerId = userAnswerId
            };

            await this.choicesRepository.AddAsync(choice);

            return choice;
        }
    }
}
