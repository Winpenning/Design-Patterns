public class Biblioteca 
{
    public List<Livro> livros = new List<Livro>();
    public IteratorLivro itl;
    public void adicionarLivro(Livro livro)
    {
        livros.Add(livro);      
    }
    public IteratorLivro criarIterator()
    {
        return new IteratorLivro(livros);
    }

   
}
