public class MediadorConcreto : IMediador
{
    public List<IUsuario> usuarios = new List<IUsuario>();
    public void enviarMensagem(IUsuario remetente, string mensagem)
    {
        foreach(var usuario in usuarios)
        {
            if(usuario != remetente)
            {
                usuario.receberMensagem(mensagem);
            }
        }
    }
    public void registrarUsuario(IUsuario usuario)
    {
        usuarios.Add(usuario);
    }
}
