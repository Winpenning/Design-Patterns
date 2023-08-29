public class CachorroFactory implements AnimalFactory {
    public Animal criarAnimal(){
        return new Cachorro();
    }
}
