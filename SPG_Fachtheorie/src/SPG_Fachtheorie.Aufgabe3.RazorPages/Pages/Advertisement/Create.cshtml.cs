using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SPG_Fachtheorie.Aufgabe2.Infrastructure;
using SPG_Fachtheorie.Aufgabe3.RazorPages.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SPG_Fachtheorie.Aufgabe3.RazorPages.Pages.Advertisement
{
    public class CreateModel : PageModel
    {
        private readonly PodcastContext _db;
        private readonly AuthService _authService;
        public CreateModel(PodcastContext db, AuthService authService)
        {
            _db = db;
            _authService = authService;
        }
        public record NewAddCmd(
            [StringLength(255, MinimumLength = 3, ErrorMessage = "Invalid ProductName")] string ProductName,
            int Length,
            DateTime Production,
            int? MinPlayTime,
            decimal CostsPerPlay,
            int CustomerId);

        [BindProperty]
        public NewAddCmd Advertisement { get; set; } = default!;

        public List<SelectListItem> CustomersList =>
        _db.Customers.Where(c => c.ResponsibleAdminId == _authService.AdminId)
            .Select(c => new SelectListItem($"{c.FirstName} {c.LastName}", c.Id.ToString())).ToList();

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) {return Page();}
            var customer = _db.Customers.FirstOrDefault(c => c.Id == Advertisement.CustomerId);
            if (customer is null) { return Page(); }
            if (customer.RegistrationDate > Advertisement.Production)
            {
                ModelState.AddModelError("", "Dates are incorrect");
                return Page();
            }
            var advert = new Aufgabe2.Domain.Advertisement
            {
                CustomerId = Advertisement.CustomerId,
                ProductName = Advertisement.ProductName,
                Length = Advertisement.Length,
                Production = Advertisement.Production,
                MinPlayTime = Advertisement.MinPlayTime,
                CostsPerPlay = Advertisement.CostsPerPlay
            };

            _db.Advertisements.Add(advert);

            try
            {
                _db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                ModelState.AddModelError("", e.InnerException?.Message ?? e.Message);
                return Page();
            }
            return RedirectToPage("/Customer/Index");
        }

        public void OnGet()
        {
        }
    }
}
