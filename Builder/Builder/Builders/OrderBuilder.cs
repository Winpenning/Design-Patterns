using Builder.Items;

namespace Builder.Builders
{
    public class OrderBuilder : IBuilder
    {
        private Order _Order = new();
        public void Build()
        {
            
        }

        public void BuildCategory(char category)
        {
            throw new NotImplementedException();
        }

        public void BuildDescription(string description)
        {
            _Order.Description = description;
        }
    }
}
