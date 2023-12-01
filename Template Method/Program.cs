namespace Template_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Documento a = new Documento("Texto","Conteudo ABC");
            Documento b = new Documento("Planilha", "[],[],[]");

            ProcessadorDeDocumentoDeTexto p1 = new ProcessadorDeDocumentoDeTexto(a);
            ProcessadorDePlanilha p2 = new ProcessadorDePlanilha(b);

            ProcessadorDeDocumentos pd1 = new ProcessadorDeDocumentos(p1);
            ProcessadorDeDocumentos pd2 = new ProcessadorDeDocumentos(p2);

            pd1.ProcessarDocumento();
            pd2.ProcessarDocumento();
        }
    }
}   