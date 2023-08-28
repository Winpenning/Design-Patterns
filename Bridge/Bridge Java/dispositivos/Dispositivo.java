package dispositivos;

// INTERFACE COMUM PARA TODOS OS DISPOSITIVOS
public interface Dispositivo {
    // verificará se o dispositivo está ligado
    boolean ligado();

    void ligar();
    void desligar();

    int retornarVolume();
    void definirVolume(int volume);

    int retornarCanal();

    void definirCanal(int canal);

    void status();
}
