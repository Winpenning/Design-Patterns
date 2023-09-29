public class UsuarioConcreto : IUsuario
{
    public string nome { get; set; }
    public IMediador mediador { get; set; }
    public UsuarioConcreto(string nome, IMediador mediador)
    {
        this.nome = nome;
        this.mediador = mediador;
    }

    public void enviarMensagem(string mensagem)
    {
        Console.WriteLine(nome + " enviou: " + mensagem);
        mediador.enviarMensagem(this, mensagem);
    }

    public void receberMensagem(string mensagem)
    {
        Console.WriteLine(nome + " recebeu: " + mensagem);
    }
}
