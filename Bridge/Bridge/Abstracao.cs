using System;
namespace Bridge
{
    internal class Abstracao
    {
        protected IImplementacao _implementacao;

        public Abstracao(IImplementacao implementacao)
        // A INTERFACE ESTÁ SENDO PASSADA POR PARÂMETRO PARA QUE UMA CLASSE QUE A IMPLEMENTE POSSA UTILIZÁ-LA DE MANEIRA GENÉRICA
        {
            this._implementacao = implementacao;
        }

        public virtual string EfetuarTarefaAbstrata()
        {
            return "Tarefa efetuada de primeira maneira abstrata"+
                _implementacao.EfetuarTarefa();
        }
    }
}
