using Microsoft.AspNetCore.Mvc;
using WhatsArt.Data;
using WhatsArt.Models;

namespace WhatsArt.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;

        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<User> objUserList = _db.Users;
            return View(objUserList);
        }

        //GET
        public IActionResult Create()
        {
            
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User obj)
        {
            if(obj.Name == obj.Password)
            {
                ModelState.AddModelError("err1", "Please do not use your username on the password field");
            }
            if (ModelState.IsValid)
            {
                _db.Users.Add(obj);
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
            var categoryFromDb = _db.Users.Find(id);
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
        public IActionResult Edit(User obj)
        {
            if (obj.Name == obj.Password)
            {
                ModelState.AddModelError("err1", "Please do not use your username on the password field");
            }
            if (ModelState.IsValid)
            {
                _db.Users.Update(obj);
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
            var categoryFromDb = _db.Users.Find(id);
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
            var obj = _db.Users.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
          
            _db.Users.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "User succesfully deleted";
            return RedirectToAction("Index");
            
            return View(obj);
        }
    }
}
