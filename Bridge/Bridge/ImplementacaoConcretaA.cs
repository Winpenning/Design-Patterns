using System;
namespace Bridge
{
    internal class ImplementacaoConcretaA : IImplementacao
    {
        public string EfetuarTarefa()
        {
            return "Tarefa da implementação A efetuada!";
        }
    }
}
