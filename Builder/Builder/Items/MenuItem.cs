using Builder.Enums;

namespace Builder.Items
{
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
        public Rank Rank { get; set; }
        public MenuItem() { }
        public MenuItem(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string GetRank()
        {
            switch (this.Rank)
            {
                case Rank.S: return "S";
                case Rank.A: return "A";
                case Rank.B: return "B";
                case Rank.C: return "C";
                default: return "No rank!";
            }
        }
        public override string ToString()
        {
            return $"\nName: {this.Name}" +
                   $"\nPrice: {this.Price}" +
                   $"\nDescription: {this.Description}" +
                   $"\nRank: {GetRank()}";
        }

    }
}
