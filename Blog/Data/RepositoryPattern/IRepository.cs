using Blog.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Data.RepositoryPattern
{
    public interface IRepository
    {
        Post GetPost(int id);
        List<Post> GetAllPosts();
        List<Post> GetAllPosts(string category);
        void AddPost(Post post);
        void RemovePost(int id);
        void UpdatePost(Post post);
        Task<bool> SaveChangesAsync();
    }
}
