package remotos;

// INTERFACE COMUM PARA TODOS OS CONTROLES REMOTOS
public interface Remoto {
    void power();

    void aumentarVolume();
    void diminuirVolume();

    void aumentarCanal();
    void diminuirCanal();
}