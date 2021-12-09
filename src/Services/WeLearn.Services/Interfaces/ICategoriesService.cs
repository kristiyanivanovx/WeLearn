﻿using System.Collections.Generic;

using WeLearn.Web.ViewModels.Category;

namespace WeLearn.Services.Interfaces
{
    public interface ICategoriesService
    {
        int GetCount();

        IEnumerable<CategoryViewModel> GetAllCategories();
    }
}