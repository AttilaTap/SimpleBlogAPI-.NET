using Microsoft.AspNetCore.Mvc;
using SimpleBlogAPI.Models;

namespace SimpleBlogAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly BlogContext _context;
        public PostsController(BlogContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Post> Get() => _context.Posts.ToList();

        [HttpGet("{id}")]
        public ActionResult<Post> Get(int id)
        {
            var post = _context.Posts.Find(id);
            if (post == null) return NotFound();
            return post;
        }

        [HttpPost]
        public IActionResult Post(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = post.Id }, post);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Post updatedPost)
        {
            var post = _context.Posts.Find(id);
            if (post == null) return NotFound();

            post.Title = updatedPost.Title;
            post.Content = updatedPost.Content;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var post = _context.Posts.Find(id);
            if (post == null) return NotFound();

            _context.Posts.Remove(post);
            _context.SaveChanges();
            return NoContent();
        }
    }
}