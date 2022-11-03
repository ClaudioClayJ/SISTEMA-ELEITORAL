namespace MODELS
{
    public class Candidato
    {
		private string nome;
        private double numero;

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


        public Candidato(string _nome, double _numero)
        {
           nome = _nome;
           numero = _numero;
        }
        
 public void Exibir()
        {
            Console.WriteLine("Nome do Candidato: " + Nome);
            Console.WriteLine("Numero do Candidato: " + Numero);
        }

    }
}