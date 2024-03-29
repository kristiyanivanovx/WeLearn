﻿using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using WeLearn.Services.Data.Interfaces;

using WeLearn.Web.ViewModels.Comment;

namespace WeLearn.Web.ViewComponents
{
    public class AllComments : ViewComponent
    {
        private readonly IViewComponentsService viewComponentsService;

        public AllComments(IViewComponentsService viewComponentsService)
            => this.viewComponentsService = viewComponentsService;

        public async Task<IViewComponentResult> InvokeAsync(int lessonId)
        {
            IEnumerable<CommentViewModel> models = await this.viewComponentsService.GetCommentsAsync(lessonId);
            return this.View(models);
        }
    }
}
