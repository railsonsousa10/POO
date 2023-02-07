namespace Models
{
    public class Pneu
    {
        private int v1;
        private int v2;
        private string v3;

        public string? Cor { get; set; }
        public int Aro { get; set; }
        public string? Tipo{ get; set; }
        public bool TWI { get; set; }
        public int PercentualBorracha { get; set; }
        public bool Estourado { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int VelocidadeAtual { get; set; }
        public bool Estepe { get; set; }

        public Pneu(int _aro, int _velocidadeMaxima, string _tipo, bool _estepe)
        {
            Aro = _aro;
            Tipo = _tipo;   
            VelocidadeMaxima = _velocidadeMaxima;
            Estourado = _estepe;

            VelocidadeAtual = 0; 
            Estourado = false;
            TWI = false;
            Cor = "Preto";
            PercentualBorracha = 100; 
        }

        public Pneu(int v1, int v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public void Girar(int _velocidade)
        {
            VelocidadeAtual = VelocidadeAtual + _velocidade;
            PercentualBorracha = PercentualBorracha - 3;

            if (VelocidadeAtual > VelocidadeMaxima || PercentualBorracha == 30)
            {
                EstourarPneu();
            }
        }
        public void EstourarPneu()
        {
            Estourado = true;
            VelocidadeAtual = 0;
        }
        public void Freiar(int _reduzi)
        {
            VelocidadeAtual = VelocidadeAtual - _reduzi;
            PercentualBorracha = PercentualBorracha - 5;

            if (VelocidadeAtual <= 30)
            {
                EstourarPneu();
            }
            if (VelocidadeAtual < 0)
            {
                VelocidadeAtual = 0;
            }
        }

        public void Exibir()
        {
            Console.WriteLine("Aro: " + Aro);
            Console.WriteLine("PercentualBorracha: " + PercentualBorracha);
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("VelocidadeMaxima: " + VelocidadeAtual);
            Console.WriteLine("Estepe: " + Estepe);
            Console.WriteLine("Estourado: " + Estourado);
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("TWI: " + TWI);
            Console.WriteLine("VelocidadeAtual: " + VelocidadeAtual);
        }
    }
}