using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace WeLearn.Web.ViewModels.Interfaces
{
    public interface ILessonModel
    {
        IEnumerable<IFormFile> Files { get; }

        IFormFile Video { get; }
    }
}
