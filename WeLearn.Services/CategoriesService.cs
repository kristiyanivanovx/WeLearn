using System.Collections.Generic;
using WeLearn.Data.Context;
using WeLearn.Services.Interfaces;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace WeLearn.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public CategoriesService(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        //CategoryViewModel
        public async Task<IEnumerable<T>> GetAllCategoriesAsync<T>()
        {
            var categories = await context.Categories.ToListAsync();
            var categoriesViewModel = mapper.Map<T[]>(categories);
            return categoriesViewModel;
        }

        //CategoryViewModel
        public async Task<T> GetCategoryByIdAsync<T>(int id)
        {
            var categoryById = await context.Categories.FirstOrDefaultAsync(x => x.CategoryId == id);
            var categoryByIdViewModel = mapper.Map<T>(categoryById);
            return categoryByIdViewModel;
        }

        public async Task<int> GetAllCategoriesCountAsync()
        {
            var categoriesCount = await context.Categories.CountAsync();
            return categoriesCount;
        }
    }
}
