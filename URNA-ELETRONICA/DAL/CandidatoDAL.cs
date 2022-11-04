

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

        }
        public List<Candidato> Buscar(int _numero)
        {
            return new List<Candidato>();
        }
    }
}
