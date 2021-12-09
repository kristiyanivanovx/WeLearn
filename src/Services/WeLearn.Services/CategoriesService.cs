using System.Collections.Generic;
using System.Linq;

using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models;
using WeLearn.Services.Interfaces;
using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Category;

namespace WeLearn.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly IDeletableEntityRepository<Category> categoryRepository;

        public CategoriesService(IDeletableEntityRepository<Category> categoryRepository)
            => this.categoryRepository = categoryRepository;

        public IEnumerable<CategoryViewModel> GetAllCategories()
            => this.categoryRepository.All().To<CategoryViewModel>().ToArray();

        public int GetCount()
            => this.categoryRepository.All().Count();
    }
}
