using Abstract_Factory.Classes;
using Abstract_Factory.Interfaces;
namespace Abstract_Factory.Services
{
    public class FabricaCadeiraModerna : IFabricaCadeira
    {
        public ICadeira CriarCadeira()
        {
            return new CadeiraModerna();
        }
    }
}
