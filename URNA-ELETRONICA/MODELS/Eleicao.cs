
namespace MODELS
{
    public class Eleicao
    {
        private int ano;
        private int turno;
        private List<Candidato> candidatos;
        private List<Eleitor> eleitores;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public int Ano
        {
            get { return ano ; }
            set { ano = value; }
        }
        public int Turno
        {
            get { return turno; }
            set { turno = value; }
        }


        public List<Candidato> Candidatos
        {
            get { return candidatos; }
            set {  candidatos = value; }
        }

        public List<Eleitor> Eleitores
        {
            get { return eleitores; }
            set { eleitores = value; }
        }

        public Eleicao(int _ano, int _turno, int _id)
        {
            Ano = _ano;
            Turno = _turno;
            Id = _id;
        }
        public Eleicao()
        {
                
        }
        public void Exibir()
        {
            Console.WriteLine("Ano da Eleicao: " + Ano);
            Console.WriteLine("Turno: " + Turno);
        }
    }
}
