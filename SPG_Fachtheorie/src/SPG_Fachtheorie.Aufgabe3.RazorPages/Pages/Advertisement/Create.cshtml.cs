using AutoMapper; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SPG_Fachtheorie.Aufgabe2.Domain;
using SPG_Fachtheorie.Aufgabe2.Infrastructure;
using SPG_Fachtheorie.Aufgabe3.RazorPages.Classes;
using SPG_Fachtheorie.Aufgabe3.RazorPages.Dto;

namespace SPG_Fachtheorie.Aufgabe3.RazorPages.Pages.Advertisement
{
    public class CreateModel : PageModel
    {
        private readonly PodcastContext _db;
        private readonly AuthService _authService;
        private readonly IMapper _mapper;
        public CreateModel(PodcastContext db, AuthService authService, IMapper mapper)
        {
            _db = db;
            _authService = authService;
            _mapper = mapper;
        }

        public List<SelectListItem> Customers { get; set; } = new List<SelectListItem>();

        [BindProperty]
        public NewAdvertisementDto NewAdvertisement { get; set; }

        public IActionResult OnGet()
        {
            Customers = _db.Customers
                .Where(c => c.ResponsibleAdmin.Id == _authService.AdminId)
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = $"{c.FirstName} {c.LastName}"
                })
                .ToList();

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Customers = _db.Customers
                .Where(c => c.ResponsibleAdmin.Id == _authService.AdminId)
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = $"{c.FirstName} {c.LastName}"
                })
                .ToList();
                return Page();
            }

            foreach (var modelStateEntry in ModelState.Values)
            {
                foreach (var error in modelStateEntry.Errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }

            var selectedCustomerId = NewAdvertisement.CustomerId;
            var customer = _db.Customers.Include(c => c.Advertisements).FirstOrDefault(c => c.Id == selectedCustomerId);

            if (customer == null)
            {
                ModelState.AddModelError("", "Ungültiger Kunde ausgewählt.");
                return Page();
            }

            var newAdvertisement = _mapper.Map<Aufgabe2.Domain.Advertisement>(NewAdvertisement);
            newAdvertisement.Customer = customer;
            newAdvertisement.ItemType = "Advertisement";

            _db.Advertisements.Add(newAdvertisement);
            _db.SaveChanges();

            return RedirectToPage("/Customer/Index");
        }
    }
}
