using BLL;
using MODELS;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
        Eleitor eleitor = new Eleitor("Felisberto", "12345678902",1);

        EleitorBLL eleitorBLL = new EleitorBLL();
        eleitorBLL.Excluir(eleitor);


        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            
        }



        try
        {
        Candidato candidato = new Candidato("Guga", 15,1);

        CandidatoBLL candidatoBLL = new CandidatoBLL();
        candidatoBLL.Excluir(candidato);

        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);
        }




        try
        {
        Eleicao eleicao = new Eleicao(2002, 1,1);
        EleicaoBLL eleicaoBLL = new EleicaoBLL();
        eleicaoBLL.Excluir(eleicao);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}