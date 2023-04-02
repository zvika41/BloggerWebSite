using Blog.Data.FileManager;
using Blog.Data.RepositoryPattern;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repo;
        private IFileManager _fileManager;

        public HomeController(IRepository repo, IFileManager fileManager)
        {
            _repo = repo;
            _fileManager = fileManager;
        }


        //Expressions Methods
        public IActionResult Index(string category) => View(string.IsNullOrEmpty(category) ? _repo.GetAllPosts() : _repo.GetAllPosts(category));

        public IActionResult Post(int Id) => View(_repo.GetPost(Id));

        [HttpGet("/Image/{imageName}")]
        [ResponseCache(CacheProfileName = "Monthly", Duration = 60 * 60 * 24 * 7 * 4)]
        public IActionResult Image(string imageName) => new FileStreamResult(_fileManager.GetImageStream(imageName), $"image/{imageName.Substring(imageName.LastIndexOf(".") + 1)}");


        //Statements Methods
        //public IActionResult Index(string category)
        //{
        //    var posts = string.IsNullOrEmpty(category) ? _repo.GetAllPosts() : _repo.GetAllPosts(category);
        //    return View(posts);
        //} 

        //public IActionResult Post(int Id)
        //{
        //    var post = _repo.GetPost(Id);

        //    return View(post);
        //}

        //[HttpGet("/Image/{imageName}")]
        //public IActionResult Image(string imageName)
        //{
        //    var mime = imageName.Substring(imageName.LastIndexOf(".") + 1);
        //    return new FileStreamResult(_fileManager.GetImageStream(imageName), $"image/{mime}");
        //}
    }
}
