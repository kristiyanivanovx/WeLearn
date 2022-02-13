using System.Collections.Generic;
using System.Linq;

using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models.Shared;
using WeLearn.Services.Data.Interfaces;
using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Category;

namespace WeLearn.Services.Data
{
    public class CategoriesService : ICategoriesService
    {
        private readonly IDeletableEntityRepository<Category> categoryRepository;

        public CategoriesService(IDeletableEntityRepository<Category> categoryRepository)
            => this.categoryRepository = categoryRepository;

        public IEnumerable<T> GetAll<T>()
            => this.categoryRepository.All().To<T>().ToArray();

        public int GetCount()
            => this.categoryRepository.All().Count();
    }
}
