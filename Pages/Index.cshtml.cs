using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_App1.Data;
using Razor_App1.Models;

namespace Razor_App1.Pages
{
    public class IndexModel : PageModel
    {

        private readonly BlogDbContext _db;
        public IndexModel(BlogDbContext db)
        {
            _db = db;
        }
        
        public IEnumerable<Article> Articles { get; set; }

        public void OnGet()
        {
            Articles = _db.Articles;
        }
    }
}