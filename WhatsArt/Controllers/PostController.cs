using Microsoft.AspNetCore.Mvc;
using WhatsArt.Data;
using WhatsArt.Models;
using WhatsArt.Services.Interfaces;

namespace WhatsArt.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostServices postServices;
        public PostController(IPostServices _postServices)
        {
          this.postServices = _postServices;
        }
        public IActionResult Index()
        {
            IEnumerable<Post> objPostsList = postServices.GetPosts();
            return View(objPostsList);
        }

        public IActionResult HomePage()
        {
            IEnumerable<Post> objPostsList = postServices.GetPosts();
            return View(objPostsList);
        }

        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Create(Post post)
        {
            postServices.Create(post);
            return RedirectToAction("Index");
        }

        public IActionResult ViewUserPosts(int id)
        {
            IEnumerable<Post> obj = postServices.GetUserPosts(id);
            return View(obj);
        }
        public IActionResult Delete(int  id)
        {

            postServices.Delete(id);
            return RedirectToAction("Index");
        }
  
        public IActionResult Edit(int? id)
        {
            var obj = postServices.GetPostById(id);
            return View(obj);
        }
  
        [HttpPost]
        public IActionResult EditPost(Post obj)
        {
            
            postServices.EditPost(obj);
            return RedirectToAction("Index");
        }
    }
}
