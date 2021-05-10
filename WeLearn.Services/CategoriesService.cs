using System.Collections.Generic;
using WeLearn.Data;
using WeLearn.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WeLearn.ViewModels;
using AutoMapper;
using System.Linq;

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

        public IEnumerable<CategoryViewModel> GetAllCategories()
            => mapper.Map<CategoryViewModel[]>(context.Categories.ToArray());

        public async Task<int> GetAllCategoriesCountAsync()
            => await context.Categories.CountAsync();
    }
}
