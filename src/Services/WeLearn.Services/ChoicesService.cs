using System.Threading.Tasks;

using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models.Quiz;

namespace WeLearn.Services
{
    public class ChoicesService
    {
        private readonly IDeletableEntityRepository<Choice> choicesRepository;

        // todo: interface
        public ChoicesService(IDeletableEntityRepository<Choice> choicesRepository)
        {
            this.choicesRepository = choicesRepository;
        }

        public async Task<Choice> CreateAsync(int questionId, int userAnswerId)
        {
            var choice = new Choice
            {
                QuestionId = questionId,
                UserAnswerId = userAnswerId
            };

            await this.choicesRepository.AddAsync(choice);
            await this.choicesRepository.SaveChangesAsync();

            return choice;
        }
    }
}
