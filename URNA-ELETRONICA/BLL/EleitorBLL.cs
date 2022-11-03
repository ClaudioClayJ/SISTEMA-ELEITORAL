using MODELS;
using DAL;

namespace BLL
{
    public class EleitorBLL
    {
        public void Inserir(Eleitor _eleitor)
        {
            if(_eleitor.Nome.Length <= 2)
            {
                throw new Exception("O nome do eleitor deve ter mais de duas letras");
            }
            EleitorDAL eleitorDAL = new EleitorDAL();
            eleitorDAL.Inserir(_eleitor);
        }
        public void Excluir(Eleitor _eleitor)
        {
            EleitorDAL eleitorDAL = new EleitorDAL();
            eleitorDAL.Excluir(_eleitor);

        }
        public void Alterar(Eleitor _eleitor)
        {

            if (_eleitor.Nome.Length <= 2)
            {
                throw new Exception("O nome do eleitor deve ter mais de duas letras");
            }
            EleitorDAL eleitorDAL = new EleitorDAL();
            eleitorDAL.Alterar(_eleitor);

        }
        public List<Eleitor> Buscar(string _tituloEleitor)
        {
            EleitorDAL eleitorDAL = new EleitorDAL();
            return eleitorDAL.Buscar(_tituloEleitor);
        }
    }
}
