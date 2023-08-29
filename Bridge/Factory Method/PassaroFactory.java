public class PassaroFactory implements AnimalFactory {
    public Animal criarAnimal(){
        return new Passaro();
    }
}
