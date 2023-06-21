using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SPG_Fachtheorie.Aufgabe2.Infrastructure;
using SPG_Fachtheorie.Aufgabe3.RazorPages.Classes;

namespace SPG_Fachtheorie.Aufgabe3.RazorPages.Pages.Advertisement
{
    public class DetailsModel : PageModel
    {
        private readonly PodcastContext _db;
        private readonly AuthService _authService;

        public DetailsModel(PodcastContext db, AuthService authService)
        {
            _db = db;
            _authService = authService;
        }
        [BindProperty]
        public Aufgabe2.Domain.Advertisement Advertisement { get; set; }

        public IActionResult OnGet(int id)
        {
            Advertisement = _db.Advertisements
                .Include(a => a.Customer)
                .FirstOrDefault(a => a.Id == id && a.Customer.ResponsibleAdmin.Id == _authService.AdminId);

            if (Advertisement == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
