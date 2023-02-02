using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneu pneu1 = new Pneu(16, 150, "Carro de passeio", false);
          
            Pneu pneu2 = new Pneu(16, 70, "Pneu de estepe", true);
           
          
            pneu1.Girar(6);
            pneu2.Girar(6);
            pneu2.Girar(15);
            pneu2.Girar(10);
            pneu2.Freiar(5);
            pneu2.Girar(6);
            pneu2.Girar(50);
            pneu1.Exibir();
            Console.WriteLine();
            pneu1.Exibir();
        }
    }
}