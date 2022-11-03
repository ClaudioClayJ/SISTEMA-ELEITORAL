

using DAL;
using MODELS;

namespace BLL
{
    public class EleicaoBLL
    {
        public void Inserir(Eleicao _eleicao)
        {

        }
        public void Excluir(Eleicao _eleicao)
        {
            EleicaoDAL _eleicaoDAL = new EleicaoDAL();
            EleicaoDAL.Excluir(_eleicao);
        }
        public void Alterar(Eleicao _eleicao)
        {

            if (_eleicao.Nome.Length <= 2)
            {
                throw new Exception("O nome do eleitor deve ter mais de duas letras");
            }
            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            eleicaoDAL.Alterar(_eleicao);
        }
        public List<Eleicao> Buscar(int _ano, int _turno)
        {
            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            return eleicaoDAL.Buscar(_ano, _turno);
        }
    }
}
