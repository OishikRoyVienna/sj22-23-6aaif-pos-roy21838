namespace SPG_Fachtheorie.Aufgabe1.Model
{
    public class Category
    {
        public Category(string name, bool onlyPremium)
        {
            Name = name;
            OnlyPremium = onlyPremium;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool OnlyPremium { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Category() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    }
}