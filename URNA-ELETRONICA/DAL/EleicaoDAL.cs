

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
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {

                cmd.CommandText = "UPDADE Eleicao SET Ano = @Ano, Turno= @Turno, Id= @Id WHERE Id = @Id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Ano", _eleicao.Ano);
                cmd.Parameters.AddWithValue("@Turno", _eleicao.Turno);
                cmd.Parameters.AddWithValue("@Turno", _eleicao.Id);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {

                cmd.Connection.Close();

            }
        }
        public DataTable BuscarPorEleicao(int _id)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                da.SelectCommand = cn.CreateCommand();
                da.SelectCommand.CommandText = "SELECT  Id ,Ano , Turno FROM Eleicao WHERE Id = @Id";
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.AddWithValue("Eleicao", _id);
                cn.Open();
                da.Fill(dt);
                return dt;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
