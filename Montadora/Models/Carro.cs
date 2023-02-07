namespace Models
{
    public class Carro
    {
     
        public int Odometro { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public int QuantidadeEixo { get; set; }
        public int VelocidadeMaxima { get; set; }
        public bool Ligado { get; set; }
        public int PercentualCobustivel { get; set; }
        public Pneu PneuDianteiroEsquerdo { get; set; }
        public Pneu PneuDianteiroDireito { get; set; }
        public Pneu PneuTraseiroEsquerdo { get; set; }
        public Pneu PneuEstepe { get; set; }
        public Pneu PneuTraseiroDireito { get; set; }
        public int VelocidadeAtual { get; private set; }

        public Carro(string _marca, string _modelo, int _ano, int _velocidadeMaxima, string _placa)
        {
            Marca = _marca;
            Modelo = _modelo;
            VelocidadeMaxima = _velocidadeMaxima;
            Placa = _placa;
            Odometro = 0;
            Ligado = false;
            PneuDianteiroDireito = new Pneu(16, 150, "Carro de passeio");
            PneuDianteiroEsquerdo = new Pneu(16, 150, "Carro de passeio");
            PneuTraseiroDireito = new Pneu(16, 150, "Carro de passeio");
            PneuTraseiroEsquerdo = new Pneu(16, 150, "Carro de passeio");
            PneuEstepe = new Pneu(16, 70, "Pneu de estepe", true);

        }
        public void Ligar()
        {
     
                if (PercentualCobustivel > 0)
                {
                    PercentualCobustivel = PercentualCobustivel - 3;
                    Ligado = true;
                    if (PercentualCobustivel <= 0)
                    {
                        PercentualCobustivel = 0;
                        Desligar();
                    }
                }
        }
        public void Desligar()
        {
            Ligado = false;

        }

        public int GetPercentualCobustivel()
        {
            return PercentualCobustivel;
        }

        public void Acelerar(int _impulso, int _percentualCobustivel)
        {
            if (Ligado == true && _impulso > 0)
            {
                Odometro += 18;
                PercentualCobustivel = PercentualCobustivel - 8;
                VelocidadeAtual = VelocidadeAtual + _impulso;
                PneuDianteiroDireito.Girar(_impulso);
                PneuDianteiroEsquerdo.Girar(_impulso);
                PneuTraseiroDireito.Girar(_impulso);
                PneuTraseiroEsquerdo.Girar(_impulso);
            }
        }
        public void Freiar(int _reduzir)
        { 
            VelocidadeAtual = VelocidadeAtual - _reduzir;

            if (VelocidadeAtual < 0)
                VelocidadeAtual = 0;
        }
        /// <summary>
        /// Este métado vai abastecer o carro
        /// </summary>
        /// <param name="_quantidadeCombustivel">Informe a qunatidade de combustivel que deseja abastecer, 
        /// caso informe 0 o metado irá completar o tanque.
        /// O valor não pode ser superior a 100</param>param>
        public void Abastecer(int _quantidadeCombustivel = 0)
        {
            if (_quantidadeCombustivel == 0)
                _quantidadeCombustivel = 100 - PercentualCobustivel;
            
            if (PercentualCobustivel + _quantidadeCombustivel > 100)
            {
                Console.WriteLine("A quantidade de combustivel ultrapassa o limite do tamque! ");
                return;
            }

            if (PercentualCobustivel < 100)
                PercentualCobustivel = PercentualCobustivel + _quantidadeCombustivel;
        }
        public void Exibir()
        {


            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Ano: " + Ano);
            Console.WriteLine("Placa: " + Placa);
            Console.WriteLine("VelocidadeMaxima: " + VelocidadeMaxima);
            Console.WriteLine("VelocidadeAtual: " + VelocidadeAtual);
            Console.WriteLine("Odometro: " + Odometro);
            Console.WriteLine("Ligado: " + Ligado);
            Console.WriteLine("PercentualCombustivel: " + PercentualCobustivel);

            Console.WriteLine("\nPneuDiateiroDireito");
            PneuDianteiroDireito.Exibir();
            Console.WriteLine("\nPneuDianteiroEsquerdo");
            PneuDianteiroEsquerdo.Exibir();
            Console.WriteLine("\nPneuTraseiroDireito");
            PneuTraseiroDireito.Exibir();
            Console.WriteLine("\nPneuTraseiroEsquerdo");
            PneuTraseiroEsquerdo.Exibir();
        }
    }
}