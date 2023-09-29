public class DocumentoMemento
{
    private string texto;
    private string titulo;

    public DocumentoMemento(string texto, string titulo)
    {
        this.texto = texto;
        this.titulo = titulo;
    }
    public string getTexto()
    {
        return this.texto;
    }
    public string getTitulo()
    {
        return this.titulo;
    }
}
