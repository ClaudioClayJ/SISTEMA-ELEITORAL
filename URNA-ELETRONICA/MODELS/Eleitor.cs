using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class Eleitor
    {
		private string nome;
        private double cpf;
        private string tituloEleitor;
        private bool votou;

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}


        public double Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

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


        public Eleitor(string _nome, string _tituloEleitor)
        {
            Nome = _nome;
            TituloEleitor = _tituloEleitor;
            Votou = true;

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
        public void Exibir()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + Cpf);
        }
     }
        

       
    }

