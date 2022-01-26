using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models.Quiz;
using WeLearn.Services.Mapping;

namespace WeLearn.Services.Data
{
    public class ExaminationsService
    {
        private readonly IDeletableEntityRepository<Examination> examinationRepository;

        public ExaminationsService(IDeletableEntityRepository<Examination> examinationRepository)
            => this.examinationRepository = examinationRepository;

        public int GetCount()
            => this.examinationRepository
                .All()
                .Count();

        public bool Contains(int id)
            => this.examinationRepository
                .All()
                .Any(x => x.Id == id);

        public async Task CreateAsync(int quizId, int points, string userId, List<Choice> choices)
        {
            var examination = new Examination
            {
                Choices = choices,
                QuizId = quizId,
                Points = points,
                ApplicationUserId = userId,
            };

            await this.examinationRepository.AddAsync(examination);
            await this.examinationRepository.SaveChangesAsync();
        }

        public Examination GetExaminationById(int id)
            => this.examinationRepository
                .All()
                .Include(x => x.Quiz)
                .Include(x => x.ApplicationUser)
                .FirstOrDefault(x => x.Id == id);

        public IEnumerable<T> GetById<T>(int id)
            => this.examinationRepository
                .All()
                .Where(x => x.Id == id)
                .Include(x => x.Quiz)
                    .ThenInclude(x => x.Questions)
                        .ThenInclude(x => x.Answers)
                .AsSingleQuery()
                .To<T>()
                .ToList();

        public IEnumerable<T> GetAll<T>()
            => this.examinationRepository
                .All()
                .Include(x => x.Quiz)
                    .ThenInclude(x => x.Questions)
                        .ThenInclude(x => x.Answers)
                .AsSingleQuery()
                .To<T>()
                .ToList();
    }
}
