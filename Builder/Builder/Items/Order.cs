using System.Collections.Generic;
namespace Builder.Items
{
    public class Order
    {
        List<MenuItem> items = new List<MenuItem>();
        public string Description { get; set; }
        public string Category { get; set; }
        public void Add(MenuItem item) { items.Add(item); }
        public void ListParts() 
        {
            foreach (MenuItem item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
