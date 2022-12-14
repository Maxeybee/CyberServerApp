using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CyberServerApp.Controllers
{
    [Authorize]
    public class RoleController : Controller
    {
        private RoleManager<IdentityRole> _roleManager;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            // CS0029 
            _roleManager = roleManager;
        }

        //[Authorize(Roles = "Admin")]
        // GET: RoleController
        public ActionResult Index()
        {
            var roles = _roleManager.Roles.
                ToList();  
            return View(roles);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new IdentityRole());
        }

        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            await _roleManager.CreateAsync(role);
            return View();
        }
    }
}
