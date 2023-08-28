import dispositivos.Dispositivo;
import remotos.ControleRemoto;
import remotos.ControleRemotoAvancado;
public class Integrador {
    
    protected Dispositivo dispositivo;
    
    public Integrador(Dispositivo dispositivo){ this.dispositivo = dispositivo; }

    public void UtilizandoControleRemoto()
    {
        ControleRemoto controleRemoto = new ControleRemoto(dispositivo);

        controleRemoto.power();

        for(int i = 0; i < 10; i+=1){
            controleRemoto.aumentarVolume();
        }

        controleRemoto.aumentarCanal();
        controleRemoto.aumentarCanal();

        controleRemoto.diminuirVolume();

        dispositivo.status();
        System.out.println("-   -   -   -   -   -   -   -");
    }

    public void UtilizandoControleRemotoAvancado(){
        ControleRemotoAvancado controleRemotoAvancado = new ControleRemotoAvancado(dispositivo);

        controleRemotoAvancado.power();

        controleRemotoAvancado.mutar();
        controleRemotoAvancado.aumentarCanal();

        dispositivo.status();
        System.out.println("-   -   -   -   -   -   -   -");

    }

}
