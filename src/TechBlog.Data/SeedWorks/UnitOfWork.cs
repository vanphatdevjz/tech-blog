using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBlog.Core.SeedWorks;
namespace TechBlog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TechBlogContext _context;

        public UnitOfWork(TechBlogContext context)
        {
            _context = context;
        }
        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
