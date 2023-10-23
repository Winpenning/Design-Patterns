public class Documento
{
    public string tipo { get; set; }
    private string conteudo { get; set; }

    public Documento(string tipo, string conteudo)
    {
        this.tipo = tipo;
        this.conteudo = conteudo;
    }

    public string getConteudo()
    {
        return conteudo;
    }

    public override string ToString()
    {
        return tipo + " " + conteudo;   
    }
}
