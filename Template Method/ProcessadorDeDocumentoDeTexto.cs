public class ProcessadorDeDocumentoDeTexto : ProcessadorDeDocumento
{
    public Documento? doc { get; set; }
    public ProcessadorDeDocumentoDeTexto(Documento doc)
    {
        this.doc = doc;
    }
    public override void AbrirDocumento()
    {
        Console.WriteLine(doc);
    }

    public override void LerConteudo()
    {
        doc.getConteudo();
    }

    public override void FecharDocumento()
    {
        this.doc = null;
    }
    public override string ToString()
    {
        return "\nTipo do documento: " + this.doc.tipo;
    }
}
