public class IteratorLivro : IIterator<Livro>
{
    public List<Livro> LivroList;
    public int posicao { get; set; } = 0;
    public IteratorLivro(List<Livro> list)
    {
        this.LivroList = list;
    }
    public bool hasNext()
    {
        return posicao < LivroList.Count();
    }

    public Livro next()
    {
        if(!hasNext())
        {
            throw new Exception();
        }
       return LivroList[posicao++];
    }
}
