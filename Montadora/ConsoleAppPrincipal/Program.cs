using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneu pneu1 = new Pneu(16, 150, "Carro de passeio", false);
          
            Pneu pneu2 = new Pneu(16, 70, "Pneu de estepe", true);
           
            Carro fusca = new Carro("VolksEagen", "Itamar Franco", 1994, 120, "");

            fusca.Abastecer(80);
            fusca.Ligar();
            fusca.Acelerar(15, fusca.GetPercentualCobustivel());
            fusca.Acelerar(10, fusca.GetPercentualCobustivel());
            fusca.Acelerar(15, fusca.GetPercentualCobustivel());
            fusca.Exibir();
        }
    }
}