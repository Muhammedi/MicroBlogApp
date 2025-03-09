using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Request;
using Model.Responses;
using Service;
using Service.Interfaces;

namespace MicroBlogApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IpostService _postService;

        public PostController(IpostService postService)
        {
            _postService = postService;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreatePost([FromBody] PostDto postDto)
        {
            var post = new Post
            {
                Text = postDto.Text,
                ImageUr = postDto.ImageUrl,
                Latitude = postDto.Latitude,
                Longitude = postDto.Longitude,
                CreatedAt = DateTime.UtcNow,
                Username = "testuser" // Hardcoded username for simplicity
            };

            await _postService.CreatePostAsync(post);
            return Ok(post);
        }

        [HttpGet]
        public async Task<IActionResult> GetPosts()
        {
            var posts = await _postService.GetAllPostsAsync();
            return Ok(posts);
        }
    }
}
