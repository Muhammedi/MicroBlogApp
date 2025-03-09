using DBAccess;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Request;
using Service.Interfaces;

namespace Service
{
    public class PostService : IpostService
    {
        private readonly AppDbContext _dbContext;
        public PostService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

       

        public async Task CreatePostAsync(Post post)
        {
            if (string.IsNullOrEmpty(post.Text) || post.Text.Length > 140)
                throw new ArgumentException("Text cannot be empty and must be less than 140 characters.");

            _dbContext.Posts.Add(post);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Post>> GetAllPostsAsync()
        {
            return await _dbContext.Posts.OrderByDescending(p => p.CreatedAt).ToListAsync();
        }


    }
}