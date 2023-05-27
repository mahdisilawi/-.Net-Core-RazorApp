using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_App1.Data;
using Razor_App1.Models;

namespace Razor_App1.Pages.Articles
{
    public class CreateModel : PageModel
    {
        private readonly BlogDbContext _db;
        public CreateModel(BlogDbContext db)
        {
            _db = db;
        }

        public Article Article { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(Article article)
        {
            if (ModelState.IsValid)
            {
                await _db.Articles.AddAsync(article);
                await _db.SaveChangesAsync();
                return RedirectToPage("/Index");
            }

            return Page();
          
        }
    }
}
