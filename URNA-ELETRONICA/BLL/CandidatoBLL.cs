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
            CandidatoDAL _candidatoDAL = new CandidatoDAL();
            _candidatoDAL.Alterar(_candidato);
        }
        public List<Candidato> Buscar(int _numero)
        {
            return new List<Candidato>();
        }
    }
}