namespace SPG_Fachtheorie.Aufgabe1.Model
{
    public class Podcast
    {

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Kategorie { get; set; }
        public int RadioStationId { get; set; }
        public RadioStation RadioStation { get; set; }
        public string Titel { get; set; }
        public int Laenge { get; set; }

        public Podcast(int categoryId, Category kategorie, string titel, int laenge, int radiostationId, RadioStation radiostation)
        {
            CategoryId = categoryId;
            Kategorie = kategorie;
            Titel = titel;
            Laenge = laenge;
            RadioStationId = radiostationId;
            RadioStation = radiostation;

        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Podcast() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}