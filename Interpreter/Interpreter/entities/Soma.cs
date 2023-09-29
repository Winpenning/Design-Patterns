namespace Interpreter.entities
{
    public class Soma : IExpressao
    {
        public Numero n1 { get; set; }
        public Numero n2 { get; set; }
        public Numero result { get; set; } = new Numero(0);

        public Soma(Numero n1, Numero n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public int interpretar()
        {
            result.numero = n1.interpretar() + n2.interpretar();
            return n1.interpretar() + n2.interpretar();
        }
    }
}
