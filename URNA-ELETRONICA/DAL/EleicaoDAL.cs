

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

                cmd.CommandText = "INSERT INTO Eleicao(Ano, Turno) VALUES(@Ano, @Turno)";
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
        public void Excluir(int _id)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "DELETE FROM Eleitor WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", _id);
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

                cmd.CommandText = "UPDADE Eleicao SET Ano = @Ano, Turno= @Turno WHERE Id = @Id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Ano", _eleicao.Ano);
                cmd.Parameters.AddWithValue("@Turno", _eleicao.Turno);
                cmd.Parameters.AddWithValue("@Id", _eleicao.Id);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {

                cmd.Connection.Close();

            }
        }
        public DataTable BuscarPorAno(int _ano)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                da.SelectCommand = cn.CreateCommand();
                da.SelectCommand.CommandText = "SELECT  Id ,Ano , Turno FROM Eleicao WHERE Ano = @Ano";
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.AddWithValue("Ano", _ano);
                cn.Open();
                da.Fill(dt);
                return dt;
            }
            finally
            {
                cn.Close();
            }
            
        }

        public DataTable BuscarPorTurno(int _turno)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                da.SelectCommand = cn.CreateCommand();
                da.SelectCommand.CommandText = "SELECT  Id ,Ano , Turno FROM Eleicao WHERE Turno = @Turno";
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.AddWithValue("Turno", _turno);
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
