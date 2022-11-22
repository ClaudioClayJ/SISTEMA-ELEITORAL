using MODELS;
using DAL;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace BLL
{
    public class EleitorBLL
    {
        public void Inserir(Eleitor _eleitor)
        {
            if(_eleitor.Nome.Length <= 2)
            {
                throw new Exception("O nome do eleitor deve ter mais de duas letras");
            }
            EleitorDAL eleitorDAL = new EleitorDAL();
            eleitorDAL.Inserir(_eleitor);
        }

        public  void Excluir(int _id)
        {
            EleitorDAL _eleitorDAL = new EleitorDAL();
            _eleitorDAL.Excluir(_id);
        }
        public void Excluir(Eleitor _eleitor)
        {
            Excluir(_eleitor.Id);

        }
        public void Alterar(Eleitor _eleitor)
        {

            EleitorDAL eleitorDAL = new EleitorDAL();
            eleitorDAL.Alterar(_eleitor);


        }
        public DataTable BuscarPorTitulo(string _tituloEleitor)
        {
            EleitorDAL eleitorDAL = new EleitorDAL();
            return eleitorDAL.BuscarPorTitulo(_tituloEleitor);
        }

        public DataTable BuscarPorNome(string _nome)
        {
            EleitorDAL eleitorDAL = new EleitorDAL();
            return eleitorDAL.BuscarPorNome(_nome);
        }

        public object BuscarPorId(int _id)
        {
            EleitorDAL eleitorDAL = new EleitorDAL();
            return eleitorDAL.BuscarPorId(_id);
        }

        public DataTable BuscarTodos()
        {
            EleitorDAL eleitorDAL = new EleitorDAL();
            return eleitorDAL.BuscarTodos();
        }
    }
}
