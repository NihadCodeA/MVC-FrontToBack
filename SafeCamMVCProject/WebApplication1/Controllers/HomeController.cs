using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeViewModel homeVM =new HomeViewModel
            {
                Sliders=_db.Sliders.ToList(),
                Services=_db.Services.ToList(),
                About=_db.About.ToList(),
                Offer=_db.Offer.ToList(),
                Teams=_db.Teams.ToList(),
                Testimonials = _db.Testimonials.ToList(),
                BlogPosts = _db.BlogPosts.ToList(),
            };
            return View(homeVM);
        }
    }
}
