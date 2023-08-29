public class GatoFactory implements AnimalFactory{
    public Animal criarAnimal(){
        return new Gato();
    }
}
