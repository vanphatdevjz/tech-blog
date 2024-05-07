using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBlog.Core.Domain.Content;
using TechBlog.Core.Repositories;
using TechBlog.Data.SeedWorks;

namespace TechBlog.Data.Repositories
{
    public class PostRepository : RepositoryBase<Post, Guid>, IPostRepository
    {
        public PostRepository(TechBlogContext context) : base(context)
        {
        }

        public Task<List<Post>> GetPopularPostsAsync(int count)
        {
            return _context.Posts.OrderByDescending(x => x.ViewCount).Take(count).ToListAsync();
        }
    }
}
