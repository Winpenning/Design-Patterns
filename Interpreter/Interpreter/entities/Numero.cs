public class Numero : IExpressao
{
    public int numero;
    public int interpretar()
    {
        return numero;
    }
    public Numero(int numero)
    {
        this.numero = numero;
    }
}
