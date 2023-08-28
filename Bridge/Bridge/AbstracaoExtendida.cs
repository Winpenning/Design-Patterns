namespace Bridge
{
    internal class AbstracaoExtendida : Abstracao
    {
        public AbstracaoExtendida(IImplementacao implementacao) : base(implementacao) { }

        public override string EfetuarTarefaAbstrata()
        {
            return "Tarefa efetuade da segunda maneira abstrata " +
                base._implementacao.EfetuarTarefa();
        }
    }
}
