using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

namespace SPG_Fachtheorie.Aufgabe1.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Email { get; set; }
        public DateTime Startdatum { get; set; }
        public DateTime? Endedatum { get; set; }

        public User(string vorname, string nachname, string email, DateTime startdatum, DateTime? endedatum)
        {
            Vorname = vorname;
            Nachname = nachname;
            Email = email;
            Startdatum = startdatum;
            Endedatum = endedatum;
        }

        public string UserType { get; set; } = default!;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public User() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.



    }
}