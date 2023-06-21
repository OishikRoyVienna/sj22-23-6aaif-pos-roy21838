using System;

namespace SPG_Fachtheorie.Aufgabe1.Model
{
    public class UserStandard : User
    {
        public bool Informed { get; set; }

        public UserStandard(string vorname, string nachname, string email, DateTime startdatum, DateTime? endedatum, bool informed) : base(vorname: vorname, nachname: nachname, email: email, startdatum: startdatum, endedatum: endedatum)
        {
            Informed = informed;
        }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public UserStandard() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}