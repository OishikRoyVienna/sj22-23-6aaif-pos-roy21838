using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SPG_Fachtheorie.Aufgabe2.Infrastructure;
using SPG_Fachtheorie.Aufgabe2.Domain;
using SPG_Fachtheorie.Aufgabe3.RazorPages.Dto;


namespace SPG_Fachtheorie.Aufgabe3.RazorPages.Pages.Playlist
{
    public class IndexModel : PageModel
    {
        private readonly PodcastContext _db;

        public IndexModel(PodcastContext db)
        {
            _db = db;
        }


        [BindProperty]
        public List<PlaylistDto> Playlists { get; set; } = new List<PlaylistDto>();
        public void OnGet()
        {
            Playlists = _db.Playlists
             .Select(p => new PlaylistDto
             {
                 Name = p.Name,
                 UserName = p.UserName,
                 NumberOfPodcasts = p.ListenedItems.Count(li => li.Item is Podcast)
             })
             .OrderBy(p => p.Name)
             .ToList();
        }
    }
}
