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

            CandidatoDAL candidatoDAL = new CandidatoDAL();
            candidatoDAL.Inserir(_candidato);

        }
        public void Excluir(Candidato _candidato)
        {
            CandidatoDAL candidatoDAL = new CandidatoDAL();
            candidatoDAL.Excluir(_candidato);
        }
        public void Alterar(Candidato _candidato)
        {
            CandidatoDAL candidatoDAL = new CandidatoDAL();
            candidatoDAL.Alterar(_candidato);
        }
        public DataTable BuscarPorNumero(int _numero)
        {
            CandidatoDAL candidatoDAL = new CandidatoDAL();
            return  candidatoDAL.BuscarPorNumero( _numero);
        }

        public DataTable BuscarTodos()
        {
            CandidatoDAL candidatoDAL = new CandidatoDAL();
            return candidatoDAL.BuscarTodos();
        }

        public DataTable BuscarPorNome(string _nome)
        {
            CandidatoDAL candidatoDAL = new CandidatoDAL();
            return candidatoDAL.BuscarPorNome(_nome);
        }
    }
}