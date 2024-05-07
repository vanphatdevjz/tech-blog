using TechBlog.Core.Domain.Content;
using TechBlog.Core.SeedWorks;

namespace TechBlog.Core.Repositories
{
    public interface IPostRepository : IRepository<Post, Guid>
    {
        Task<List<Post>> GetPopularPostsAsync(int count);
    }
}
