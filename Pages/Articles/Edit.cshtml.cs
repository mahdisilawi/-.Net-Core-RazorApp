using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_App1.Data;
using Razor_App1.Models;

namespace Razor_App1.Pages.Articles
{
    public class EditModel : PageModel
    {
        private readonly BlogDbContext _db;
        public EditModel(BlogDbContext db)
        {
            _db = db;
        }

        public Article Article { get; set; }
        public void OnGet(int? id)
        {
            Article = _db.Articles.Find(id);
        }

        public async Task<IActionResult> OnPost(Article article)
        {
            if (ModelState.IsValid)
            {
                 _db.Articles.Update(article);
                await _db.SaveChangesAsync();
                return RedirectToPage("/Index");
            }

            return Page();
          
        }
    }
}
