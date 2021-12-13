using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models.Quiz;
using WeLearn.Services.Mapping;

namespace WeLearn.Services
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

        public Examination GetExaminationById(int id)
            => this.examinationRepository
                .All()
                .Include(x => x.QuizId)
                .FirstOrDefault(x => x.Id == id);

        public IEnumerable<T> GetById<T>(int id)
            => this.examinationRepository
                .All()
                .Where(x => x.Id == id)
                .To<T>()
                .ToList();

        public IEnumerable<T> GetAll<T>()
            => this.examinationRepository
                .All()
                .Include(x => x.Quiz)
                .To<T>()
                .ToList();
    }
}
