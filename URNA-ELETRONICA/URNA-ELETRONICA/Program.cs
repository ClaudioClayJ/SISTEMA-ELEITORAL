using BLL;
using MODELS;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Eleitor eleitor = new Eleitor("Felisberto", "12345678902");

        EleitorBLL eleitorBLL = new EleitorBLL();
        eleitorBLL.Inserir(eleitor);*/

        /*Candidato candidato = new Candidato("Guga", 15);

        CandidatoBLL candidatoBLL = new CandidatoBLL();
        candidatoBLL.Inserir(candidato);*/

        Eleicao eleicao = new Eleicao(2002, 1);
        EleicaoBLL eleicaoBLL = new EleicaoBLL();
        eleicaoBLL.Inserir(eleicao);
    }
}