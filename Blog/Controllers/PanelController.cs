using Blog.Data.FileManager;
using Blog.Data.RepositoryPattern;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PanelController : Controller
    {
        private IRepository _repo;
        private IFileManager _fileManager;

        public PanelController(IRepository repo, IFileManager fileManager)
        {
            _repo = repo;
            _fileManager = fileManager;
        }


        public IActionResult Index()
        {
            var posts = _repo.GetAllPosts();
            return View(posts);
        }

        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return View(new PostViewModel());
            }
            else
            {
                var post = _repo.GetPost((int)Id);
                return View(new PostViewModel
                {
                    Id = post.Id,
                    Title = post.Title,
                    Body = post.Body,
                    CurrentImage = post.Image,
                    Description = post.Description,
                    Tags = post.Tags,
                    Category = post.Category
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PostViewModel postViewModel)
        {
            var post = new Post
            {
                Id = postViewModel.Id,
                Title = postViewModel.Title,
                Body = postViewModel.Body,
                Description = postViewModel.Description,
                Tags = postViewModel.Tags,
                Category = postViewModel.Category
            };

            HandlePostImage(postViewModel, post);
            HandlePostData(post);
            

            if (await _repo.SaveChangesAsync())
            {
                return RedirectToAction("Index", "Panel");
            }
            else
            {
                return View(post);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Remove(int Id)
        {
            _repo.RemovePost(Id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        private async void HandlePostImage(PostViewModel postViewModel, Post post)
        {
            if (postViewModel.Image == null)
            {
                post.Image = postViewModel.CurrentImage;
            }
            else
            {
                if (!string.IsNullOrEmpty(postViewModel.CurrentImage))
                {
                    _fileManager.RemoveImage(postViewModel.CurrentImage);
                }

                post.Image = await _fileManager.SaveImage(postViewModel.Image);
            }
        }

        private void HandlePostData(Post post)
        {
            if (post.Id > 0)
            {
                _repo.UpdatePost(post);
            }
            else
            {
                _repo.AddPost(post);
            }
        }
    }
}
