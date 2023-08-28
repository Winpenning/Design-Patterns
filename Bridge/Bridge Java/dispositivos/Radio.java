package dispositivos;

public class Radio implements Dispositivo {
    private boolean ligado = false;
    private int volume = 30;
    private int canal = 2;
 
    @Override
    public boolean ligado() {
        return ligado;
    }

    @Override
    public void ligar(){
        ligado = true;
    }
    
    @Override
    public void desligar(){
        ligado = false;
    }

    @Override
    public int retornarVolume(){
        return volume;
    }

    @Override
    public void definirVolume(int volume){
        if(volume >= 0 && volume <= 100){
            this.volume = volume;
        }
        else{
            System.out.println("\nVolume inválido");
        }
    }

    @Override
    public int retornarCanal(){
        return canal;
    }

    @Override
    public void definirCanal(int canal){
        if(canal > 0){
            this.canal = canal;
        }
        else{
            System.out.println("\nCanal inválido!");
        }
    }

    @Override
    public void status(){
        System.out.println("\n Rádio ");
        System.out.println("\n Estou " + (ligado ? "ligado!" : "desligado!"));
        System.out.println("\n Volume " + volume);
        System.out.println("\n Canal " + canal);
    }
}
