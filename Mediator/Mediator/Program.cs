IMediador mediador = new MediadorConcreto();

IUsuario usuario0 = new UsuarioConcreto("paulo", mediador);
IUsuario usuario1 = new UsuarioConcreto("henrique", mediador);
IUsuario usuario2 = new UsuarioConcreto("ziemer", mediador);

mediador.registrarUsuario(usuario0);
mediador.registrarUsuario(usuario2);
usuario0.enviarMensagem("Olá, Henrique!");
mediador.registrarUsuario(usuario1);
usuario1.enviarMensagem("Olá, pessoal!");
usuario2.enviarMensagem("Olá, pessoal!");
