public interface IMediador
{
    void registrarUsuario(IUsuario usuario);
    void enviarMensagem(IUsuario remetente, string mensagem);
}
