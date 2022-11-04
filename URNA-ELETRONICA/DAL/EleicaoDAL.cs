

using MODELS;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class EleicaoDAL
    {
        public void Inserir(Eleicao _eleicao)
        {
            {
                SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
                SqlCommand cmd = cn.CreateCommand();
                try
                {

                cmd.CommandText = "INSERT INTO Eleicao(Ano, Turno) VALUES(@Ano, @Turnoº)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Ano", _eleicao.Ano);
                cmd.Parameters.AddWithValue("@Turno", _eleicao.Turno);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                }
                finally
                {

                cmd.Connection.Close();
                   
                }


            }
        }
        public void Excluir(Eleicao _eleicao)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "DELETE FROM Eleitor WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", _eleicao.Id);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {

                cn.Close();
            }
        }
        public void Alterar(Eleicao _eleicao)
        {

        }
        public List<Eleicao> Buscar(int _ano, int _turno)
        {
            return new List<Eleicao>();
        }
    }
}
