using System.Reflection.Metadata.Ecma335;

namespace SPG_Fachtheorie.Aufgabe1.Model
{
    public class RadioStation
    {
        public RadioStation(string name, string adresse, bool online, bool offline, string link, string frequenz)
        {

            Name = name;
            Adresse = adresse;
            Online = online;
            Offline = offline;
            Link = link;
            Frequenz = frequenz;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adresse { get; set; }
        public bool Online { get; set; }
        public bool Offline { get; set; }
        public string Link { get; set; }
        public string Frequenz { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public RadioStation() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    }
}