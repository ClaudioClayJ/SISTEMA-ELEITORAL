

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
        public void Excluir(int _id)
        {
            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            eleicaoDAL.Excluir(_id);
        }
        public void Alterar(Eleicao _eleicao)
        {

            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            eleicaoDAL.Alterar(_eleicao);
        }
        public DataTable BuscarPorAno(int _ano)
        {
            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            return eleicaoDAL.BuscarPorAno(_ano);
        }

        public DataTable BuscarPorTurno(int _turno)
        {
            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            return eleicaoDAL.BuscarPorTurno(_turno);
        }

        public object BuscarTodos()
        {
            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            return eleicaoDAL.BuscarPorTodos();
        }
    }
}
