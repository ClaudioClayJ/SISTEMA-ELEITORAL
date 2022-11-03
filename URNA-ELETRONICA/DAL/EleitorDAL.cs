

using MODELS;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class EleitorDAL
    {
        public void Inserir(Eleitor _eleitor)
        {
           
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "INSERT INTO Eleitor(Titulo, Nome,Votou) VALUES(@Titulo, @Nome,@Votou)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Titulo", _eleitor.TituloEleitor);
            cmd.Parameters.AddWithValue("@Nome", _eleitor.Nome);
            cmd.Parameters.AddWithValue("@Votou", _eleitor.Votou);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
        public void Excluir(Eleitor _eleitor)
        {

        }
        public void Alterar(Eleitor _eleitor)
        {

        }
        public List<Eleitor> Buscar()
        {
          return new List<Eleitor>();
        }

        public List<Eleitor> Buscar(string tituloEleitor)
        {
            throw new NotImplementedException();
        }
    }
}
