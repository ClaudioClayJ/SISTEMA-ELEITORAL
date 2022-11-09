using BLL;
using MODELS;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Eleitor eleitor = new Eleitor("José", "12345678911", 1);
            EleitorBLL eleitorBLL = new EleitorBLL();
            eleitorBLL.Inserir(eleitor);
            eleitor.Nome = "Dagorlina";
            eleitor.TituloEleitor = "4582001";
            eleitor.Votou = false;
            eleitor.Id = 3;
            eleitorBLL.Alterar(eleitor);
            //eleitor.Votar();
            eleitorBLL.Excluir(eleitor);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            Candidato candidato = new Candidato("Babuino", 17, 3);
            CandidatoBLL candidatoBLL = new CandidatoBLL();
            candidato.Id = 3;
            candidato.Nome = "Dagoberto";
            candidato.Numero = 22;
            candidatoBLL.Inserir(candidato);
            candidatoBLL.Alterar(candidato);
            candidatoBLL.Excluir(candidato);
        
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            Eleicao eleicao = new Eleicao(2022, 1, 1);
            EleicaoBLL eleicaoBLL = new EleicaoBLL();
            eleicao.Id = 2;
            //eleicao.Ano = 2022;
            //eleicao.Turno = 2;
            eleicaoBLL.Excluir(eleicao);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}