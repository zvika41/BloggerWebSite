using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace Blog.Data.FileManager
{
    public interface IFileManager
    {
        FileStream GetImageStream(string imageName);
        Task<string> SaveImage(IFormFile image);
        bool RemoveImage(string imageName);
    }
}
