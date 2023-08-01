using Singleton.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite 1 para iniciar o contador");
        int esc = int.Parse(Console.ReadLine());
       
        while (esc != 0)
        {
            Counter c = Counter.getInstance();
            Console.WriteLine("\n1 retornar o contador \n2 Incrementar");
            esc = int.Parse(Console.ReadLine());
            switch (esc)
            {
                case 1:
                    int i = c.getCount();
                    Console.WriteLine(i);
                    break;
                case 2:
                    c.Increment();
                    break;

            }
        }
    }
}