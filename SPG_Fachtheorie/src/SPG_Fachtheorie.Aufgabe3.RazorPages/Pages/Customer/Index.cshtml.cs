using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SPG_Fachtheorie.Aufgabe2.Infrastructure;
using SPG_Fachtheorie.Aufgabe2.Domain;
using SPG_Fachtheorie.Aufgabe3.RazorPages.Classes;
using Microsoft.AspNetCore.Authorization;

namespace SPG_Fachtheorie.Aufgabe3.RazorPages.Pages.Customer
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly PodcastContext _db;
        private readonly AuthService _authService;

        public IndexModel(PodcastContext db, AuthService authService)
        {
            _db = db;
            _authService = authService;
        }

        public List<Aufgabe2.Domain.Customer> Customers { get; set; } = new List<Aufgabe2.Domain.Customer>();
        
        public IActionResult OnGet()
        {
            var adminId = _authService.AdminId;

            Customers = _db.Customers
                .Where(c => c.ResponsibleAdmin.Id == adminId)
                .Select(c => new Aufgabe2.Domain.Customer
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    CompanyName = c.CompanyName,
                    Advertisements = c.Advertisements
                        .Where(a => a.Length >= 5000)
                        .Select(a => new Aufgabe2.Domain.Advertisement
                        {
                            Id = a.Id,
                            ProductName = a.ProductName
                        })
                        .ToList()
                })
                .ToList();

            return Page();
        }
    }
}
