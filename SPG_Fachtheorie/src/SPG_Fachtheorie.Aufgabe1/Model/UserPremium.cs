using System;

namespace SPG_Fachtheorie.Aufgabe1.Model
{
    public class UserPremium : User
    {
        public decimal Preis { get; set; }
        public int Mitgliedschaftsdauer { get; set; }

        public UserPremium(string vorname, string nachname, string email, DateTime startdatum, DateTime? endedatum, int mitgliedschaftsdauer, decimal preis) : base(vorname: vorname, nachname: nachname, email: email, startdatum: startdatum, endedatum: endedatum)
        {
            Preis = preis;
            Mitgliedschaftsdauer = mitgliedschaftsdauer;
        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public UserPremium() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    }
}