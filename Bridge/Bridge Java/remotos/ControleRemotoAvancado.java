package remotos;
import dispositivos.Dispositivo;
public class ControleRemotoAvancado extends ControleRemoto {
    public ControleRemotoAvancado(Dispositivo dispositivo){
        super.dispositivo = dispositivo;
    }

    public void mutar(){
        dispositivo.definirVolume(dispositivo.retornarVolume() - dispositivo.retornarVolume());
        System.out.println("Botão mutar acionado!");
    }
}
