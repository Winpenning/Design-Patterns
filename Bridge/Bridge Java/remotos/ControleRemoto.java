package remotos;

import dispositivos.Dispositivo;

public class ControleRemoto implements Remoto{

    protected Dispositivo dispositivo;

    public ControleRemoto(){}

    public ControleRemoto(Dispositivo dispositivo){ this.dispositivo = dispositivo; }

    @Override
    public void power(){
        System.out.println("\nBotão power acionado!");
        if(dispositivo.ligado()){
            dispositivo.desligar();
        }else{
            dispositivo.ligar();
        }
    }
    
    @Override
    public void aumentarVolume(){
        if(dispositivo.retornarVolume() < 100)
        dispositivo.definirVolume(dispositivo.retornarVolume() + 1);
        else
        System.out.println("Volume máximo!");
    }

    @Override
    public void diminuirVolume(){
        if(dispositivo.retornarVolume() > 0)
        dispositivo.definirVolume(dispositivo.retornarVolume() - 1);
        else
        System.out.println("Volume zerado!");
    }

    @Override
    public void aumentarCanal(){
        dispositivo.definirCanal(dispositivo.retornarCanal() + 1);
    }
    public void diminuirCanal(){
        dispositivo.definirCanal(dispositivo.retornarCanal() - 1);
    }
}
