using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Classes
{
    public class CadeiraModerna : ICadeira
    {
        public void MontarCadeira()
        {
            Console.WriteLine("Cadeira moderna criada!");
        }
    }
}
