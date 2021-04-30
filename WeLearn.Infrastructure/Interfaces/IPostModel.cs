using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace WeLearn.Infrastructure.Interfaces
{
    public interface IPostModel
    {
        IEnumerable<IFormFile> Files { get; }

        IFormFile Video { get; }
    }
}
