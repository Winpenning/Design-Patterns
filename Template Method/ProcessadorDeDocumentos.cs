public class ProcessadorDeDocumentos
{
    public ProcessadorDeDocumento processador { get; set; }
    public ProcessadorDeDocumentos(ProcessadorDeDocumento p)
    {
        this.processador = p;
    }
    public void ProcessarDocumento() 
    {
        processador.AbrirDocumento();
        processador.LerConteudo();
        processador.FecharDocumento();
    }
}
