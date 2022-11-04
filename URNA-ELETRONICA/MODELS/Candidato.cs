namespace MODELS
{
    public class Candidato
    {
		private string nome;
        private double numero;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

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


        public Candidato(string _nome, double _numero, int _id)
        {
           Nome = _nome;
           Numero = _numero;
           Id = _id;
        }
        
 public void Exibir()
        {
            Console.WriteLine("Nome do Candidato: " + Nome);
            Console.WriteLine("Numero do Candidato: " + Numero);
        }

    }
}