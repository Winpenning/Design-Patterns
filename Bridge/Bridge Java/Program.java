import dispositivos.Radio;
import dispositivos.Tv;
public class Program{
    public static void main(String[] args){
        Integrador tv = new Integrador(new Tv());
        Integrador radio = new Integrador(new Radio());
        
        tv.UtilizandoControleRemoto();
        radio.UtilizandoControleRemotoAvancado();
    }
}

