using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace WeLearn.Web.ViewModels.Interfaces
{
    public interface ILessonModel
    {
        IEnumerable<IFormFile> Files { get; }
        
        IFormFile Video { get; }
    }
}
