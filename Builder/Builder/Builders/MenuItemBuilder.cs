using Builder.Items;

namespace Builder.Builders
{
    public class MenuItemBuilder : IBuilder
    {
        private MenuItem _Item = new();
        public void Reset()
        {
            this._Item = new();
        }
        public void BuildCategory(char category)
        {
            switch (category)
            {
                case 'S': _Item.Rank = Enums.Rank.S; break;
                case 'A': _Item.Rank = Enums.Rank.A; break;
                case 'B': _Item.Rank = Enums.Rank.B; break;
                case 'C': _Item.Rank = Enums.Rank.C; break;
                
            }
        }
        public void BuildDescription(string description)
        {
            this._Item.Description = description;
        }
        public void Build()
        {
            string name = "Teste de nome";
            double price = 0.10;
            this._Item = new(name, price);
            this._Item.Rank = Enums.Rank.Not;
        }
        public MenuItem GetMenuItem()
        {
            MenuItem Result = this._Item;
            this.Reset();
            return Result;
        }
    }
}
