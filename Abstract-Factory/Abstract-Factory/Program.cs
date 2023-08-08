using Abstract_Factory.Classes;
using Abstract_Factory.Interfaces;
using Abstract_Factory.Services;

IFabricaCadeira fabricaCadeiraClassica = new FabricaCadeiraClassica();
IFabricaCadeira fabricaCadeiraModerna = new FabricaCadeiraModerna();

ICadeira cadeiraClassica = fabricaCadeiraClassica.CriarCadeira();
ICadeira cadeiraModerna = fabricaCadeiraModerna.CriarCadeira();

cadeiraClassica.MontarCadeira();
cadeiraModerna.MontarCadeira();