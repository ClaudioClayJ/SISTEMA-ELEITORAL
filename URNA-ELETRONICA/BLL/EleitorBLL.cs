using MODELS;
using DAL;

namespace BLL
{
    public class EleitorBLL
    {
        public void Inserir(Eleitor _eleitor)
        {
            if(_eleitor.Nome Length <= 2)
            {
                throw new Exception("O nome do eleitor deve ter mais de duas letras")
            }
            EleitorDAL eleitorDAL = new EleitorDAL();
            eleitorDAL.Inserir(_eleitor);
        }
        public void Excluir()
        {

        }
        public void Alterar()
        {

        }
        public List<Eleitor> Buscar()
        {
            return new List<Eleitor>();
        }
    }
}
