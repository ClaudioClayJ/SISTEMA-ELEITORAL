using DAL;
using MODELS;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class CandidatoBLL
    {
        public void Inserir(Candidato _candidato)
        {
            {

                SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO Candidato(Numero, Nome) VALUES(@Numero, @Nome)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Numero", _candidato.Numero);
                cmd.Parameters.AddWithValue("@Nome", _candidato.Nome);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

            }
        }
        public void Excluir(Candidato _candidato)
        {
            CandidatoDAL candidatoDAL = new CandidatoDAL();
            candidatoDAL.Excluir(_candidato);
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