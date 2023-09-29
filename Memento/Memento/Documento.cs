public class Documento
{
    public string titulo { get; set; }
    public string texto { get; set; }

    public void escreverTexto(string titulo, string texto)
    {
        this.texto = texto;
        this.titulo = titulo;
    }
    public string getTexto()
    {
        return titulo + "\n" + texto;
    }
    public DocumentoMemento salvar()
    {
        return new DocumentoMemento(titulo, texto);
    }
    public void restaurar(DocumentoMemento memento)
    {
        texto = memento.getTexto();
        titulo = memento.getTitulo();
    }

}
