using System.Collections.Generic;
using WeLearn.Data;
using WeLearn.Services.Interfaces;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WeLearn.Data.Models;

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
        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            var categories = await context.Categories.ToListAsync();
            var categoriesViewModel = mapper.Map<Category[]>(categories);
            return categoriesViewModel;
        }

        public async Task<int> GetAllCategoriesCountAsync()
        {
            var categoriesCount = await context.Categories.CountAsync();
            return categoriesCount;
        }
    }
}
