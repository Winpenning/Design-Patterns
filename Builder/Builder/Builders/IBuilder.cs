namespace Builder.Builders
{
    public interface IBuilder
    {
        void Build();
        void BuildDescription(string description);
        void BuildCategory(char category);

    }
}
