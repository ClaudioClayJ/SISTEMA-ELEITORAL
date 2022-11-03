

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
            {

                SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO Eleicao(Ano, Turno) VALUES(@Ano, @Turno)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Ano", _eleicao.Ano);
                cmd.Parameters.AddWithValue("@Turno", _eleicao.Turno);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

            }
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
        public List<Eleicao> Buscar(int _ano, int _turno)
        {
            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            return eleicaoDAL.Buscar(_ano, _turno);
        }
    }
}
