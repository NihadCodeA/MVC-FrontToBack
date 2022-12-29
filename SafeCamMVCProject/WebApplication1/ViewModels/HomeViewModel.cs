using WebApplication1.Models;
namespace WebApplication1.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public List<Service> Services { get; set; }
        public List<About> About { get; set; }
        public List<Offer> Offer { get; set; }
        public List<Team> Teams { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<BlogPost> BlogPosts { get; set; }
    }
}
