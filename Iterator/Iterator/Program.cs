Biblioteca biblioteca = new Biblioteca();
biblioteca.adicionarLivro(new Livro(1, "One", "Eichiro"));
biblioteca.adicionarLivro(new Livro(2, "Piece", "Oda"));
biblioteca.adicionarLivro(new Livro(3, "Pirate", "Warior"));
IIterator<Livro> iterator = biblioteca.criarIterator();
Console.WriteLine(biblioteca.livros[1]);
while (iterator.hasNext())
{
    Livro livro = iterator.next();
    Console.WriteLine(livro);
}
