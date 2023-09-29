public class Livro
{
    public int id { get; set; }
    public string titulo { get; set; }
    public string nome { get; set; }

    public Livro(int id, string titulo, string nome)
    {
        this.id = id;
        this.titulo = titulo;
        this.nome = nome;
    }
    public override string ToString()
    {
        return nome + " " + titulo;
    }
}
