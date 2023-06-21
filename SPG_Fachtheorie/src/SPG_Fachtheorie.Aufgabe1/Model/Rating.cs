namespace SPG_Fachtheorie.Aufgabe1.Model
{
    public class Rating
    {

        public User User { get; set; }
        public int UserId { get; set; }
        public Podcast Podcast { get; set; }
        public int PodcastId { get; set; }
        public int Id { get; set; }
        public int Bewertung { get; set; }
        public string? Bewertungstext { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Rating() { }

        public Rating(User user, int userId, Podcast podcast, int podcastId, int bewertung, string? bewertungstext)
        {
            User = user;
            UserId = userId;
            Podcast = podcast;
            PodcastId = podcastId;
            Bewertung = bewertung;
            Bewertungstext = bewertungstext;
        }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    }
}