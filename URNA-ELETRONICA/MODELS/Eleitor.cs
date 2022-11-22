namespace MODELS
{
    public class Eleitor
    {
		private string nome;
        //private double cpf;//
        private string tituloEleitor;
        private bool votou;
        private int id;

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}


       /* public double Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }*/

        public string TituloEleitor
        {
            get { return tituloEleitor; }
            set { tituloEleitor = value; }
        }

        public bool Votou
        {
            get { return votou; }
            set { votou = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public Eleitor(string _nome, string _tituloEleitor, int _id)
        {
            Nome = _nome;
            TituloEleitor = _tituloEleitor;
            Votou = true;
            Id = _id;
        }
        public Eleitor()
        {

        }

        public void Votar()
        {
            if(Votou == false)
            {
                Console.WriteLine("Voce nao pode votar");
            }
            else
            {
                
            }
        }
     }
        

       
    }

