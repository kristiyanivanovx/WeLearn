using System.Collections.Generic;
using WeLearn.Data;
using WeLearn.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WeLearn.Data.Models;

namespace WeLearn.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ApplicationDbContext context;

        public CategoriesService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
            => await context.Categories.ToListAsync();

        public async Task<int> GetAllCategoriesCountAsync()
            => await context.Categories.CountAsync();
    }
}
