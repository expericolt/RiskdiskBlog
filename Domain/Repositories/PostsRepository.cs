using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Domain.Repositories
{
    public class PostsRepository
    {
        private readonly DbContext _context;

        public PostsRepository(DbContext context)
        {
            _context = context;
        }

        public List<Post> GetAllPosts()
        {
            return _context.Set<Post>().ToList();
        }
    }
}
