import java.util.ArrayList;
import java.util.List;

public class Zoologico {
   public static void main(String[] args){
    List<Animal> a = new ArrayList<>();
    CachorroFactory doguinho = new CachorroFactory();
    GatoFactory gatinho = new GatoFactory();
    a.add(doguinho.criarAnimal());
    a.add(gatinho.criarAnimal());
    a.add(doguinho.criarAnimal());
   } 
}
