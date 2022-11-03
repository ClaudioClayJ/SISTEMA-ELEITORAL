using BLL;
using MODELS;

internal class Program
{
    private static void Main(string[] args)
    {
        Eleitor eleitor = new Eleitor("Felisberto", "12345678902");

        EleitorBLL eleitorBLL = new EleitorBLL();
        eleitorBLL.Inserir(eleitor);

            
     }
}