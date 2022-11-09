

using DAL;
using MODELS;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class EleicaoBLL
    {
        public void Inserir(Eleicao _eleicao)
        {
            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            eleicaoDAL.Inserir(_eleicao);
        }
        public void Excluir(Eleicao _eleicao)
        {
            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            eleicaoDAL.Excluir(_eleicao);
        }
        public void Alterar(Eleicao _eleicao)
        {

            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            eleicaoDAL.Alterar(_eleicao);
        }
        public DataTable BuscarPorEleicao(int _ano)
        {
            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            return eleicaoDAL.BuscarPorEleicao(_ano);
        }
    }
}
