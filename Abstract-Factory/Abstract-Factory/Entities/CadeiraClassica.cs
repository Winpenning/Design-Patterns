using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Classes
{
    public class CadeiraClassica : ICadeira
    {
        public void MontarCadeira()
        {
            Console.WriteLine("Cadeira clássica criada!");
        }
    }
}
