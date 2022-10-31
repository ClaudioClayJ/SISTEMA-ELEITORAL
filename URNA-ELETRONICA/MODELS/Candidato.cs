namespace MODELS
{
    public class Candidato
    {
		private string nome;
        private double numero;
        private string nomePartido;
        private double numeroPartido;

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}


        public double Numero
        {
            get { return numero; }
            set { numero = value; }
        }


        public string NomePartido
        {
            get { return nomePartido; }
            set { nomePartido = value; }
        }

        public double NumeroPartido 
        {
            get { return numeroPartido; }
            set { numeroPartido = value; }
        }

        public Candidato(string _nome, double _numero, string _nomePartido, double _numeroPartido)
        {
           nome = _nome;
           numero = _numero;
           nomePartido = _nomePartido;
           numeroPartido = _numeroPartido;

        }
        
 public void Exibir()
        {
            Console.WriteLine("Nome do Candidato: " + Nome);
            Console.WriteLine("Numero do Candidato: " + Numero);
            Console.WriteLine("Nome do Partido: " + NomePartido);
            Console.WriteLine("Numero do Partido: " + NumeroPartido);
        }

    }
}