using Microsoft.AspNetCore.Mvc;
using WhatsArt.Data;
using WhatsArt.Models;
using WhatsArt.Services.Interfaces;

namespace WhatsArt.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService _userService)
        {
            this.userService = _userService;
        }
        
        public IActionResult Index()
        {
            IEnumerable<User> objUserList = userService.GetUsers();
            return View(objUserList);
        }
        public IActionResult Create()
        {
            return View(); 
           
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            userService.Create(user);

            return RedirectToAction("Index");
            
        }

    

    }
}
