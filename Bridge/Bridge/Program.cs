namespace Bridge
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Classe classe = new Classe();

            Abstracao abstracao;


            abstracao = new Abstracao(new ImplementacaoConcretaA());

            classe.CodigoClasse(abstracao);


            abstracao = new Abstracao(new ImplementacaoConcretaB());

            classe.CodigoClasse(abstracao);
        }
    }
}
