

using MODELS;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class CandidatoDAL
    {
        public void Inserir(Candidato _candidato)
        {
            {

                SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
                SqlCommand cmd = cn.CreateCommand();
                try
                {
                cmd.CommandText = "INSERT INTO Candidato(Numero, Nome) VALUES(@Numero, @Nome)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Numero", _candidato.Numero);
                cmd.Parameters.AddWithValue("@Nome", _candidato.Nome);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                }
                finally
                {

                cmd.Connection.Close();
               
                }
            }
        }
        public void Excluir(Candidato _candidato)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "DELETE FROM Eleitor WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", _candidato.Id);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Candidato _candidato)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "UPDATE Candidato SET Numero = @Numero, Nome = @Nome, Id = @Id WHERE Id = @Id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Numero", _candidato.Numero);
                cmd.Parameters.AddWithValue("@Nome", _candidato.Nome);
                cmd.Parameters.AddWithValue("@Nome", _candidato.Id);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

            }
            finally
            {

                cmd.Connection.Close();

            }
        }
        public DataTable BuscarPorNumero(int _numero)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                da.SelectCommand = cn.CreateCommand();
                da.SelectCommand.CommandText = "SELECT  Id ,Nome , Numero FROM Candidato WHERE Numero = @Numero";
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.AddWithValue("Id", _numero);
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
