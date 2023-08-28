using System;
namespace Bridge
{
    internal class ImplementacaoConcretaB : IImplementacao
    {
        public string EfetuarTarefa()
        {
            return "Tarefa da implementação B efetuada!";
        }
    }
}
