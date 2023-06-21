using System;

namespace SPG_Fachtheorie.Aufgabe1.Model
{
    public class Favorite
    {
        public Favorite(Category kategorie, User user, int categoryId, DateTime beginndatum, DateTime? endedatum)
        {
            Kategorie = kategorie;
            User = user;
            UserId = user.Id;
            CategoryId = categoryId;
            Beginndatum = beginndatum;
            Endedatum = endedatum;
        }

        public int Id { get; set; }
        public Category Kategorie { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public DateTime Beginndatum { get; set; }
        public DateTime? Endedatum { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Favorite() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}