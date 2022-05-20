﻿using Microsoft.AspNetCore.Mvc;
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
            IEnumerable<Post> objPostsList = postServices.GetAllPosts();
            return View(objPostsList);
        }

        [HttpPost]
        public IActionResult Create(Post obj)
        {
            postServices.CreatePost(obj);
            return RedirectToAction("Index");
        }

      /*  //GET
        public IActionResult Create()
        {
            
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Post obj)
        {
            
            if (ModelState.IsValid)
            {
                _db.Posts.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "User succesfully created";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id== 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.Posts.Find(id);
           // var categoryFromDbFirst = _db.Users.FirstOrDefault(u => u.Id == id);
           // var categoryFromDbSingle = _db.Users.SingleOrDefault(u => u.Id == id);

            if(categoryFromDb == null)
            {
                return NotFound();
            }    

            return View(categoryFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Post obj)
        {
            if (ModelState.IsValid)
            {
                _db.Posts.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.Posts.Find(id);
            // var categoryFromDbFirst = _db.Users.FirstOrDefault(u => u.Id == id);
            // var categoryFromDbSingle = _db.Users.SingleOrDefault(u => u.Id == id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        //POST
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteUser(int? id)
        {
            var obj = _db.Posts.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
          
            _db.Posts.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "User succesfully deleted";
            return RedirectToAction("Index");
            
            return View(obj);
        }
      */
    }
}
