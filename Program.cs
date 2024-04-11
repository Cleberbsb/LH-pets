namespace Projeto_Web_Lh_Pets_Alunos;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Projeto web -LH Pets versão 1");

     app.UseStaticFiles();
     app.MapGet("/index",(httpContexto)=> {
      httpContexto.Response.Redirect("index.html",false);
     });
      Banco dba=new Banco();
     app.MapGet("/listaClientes", {httpContexto} =>{
        Contexto.Response.WriteAsyne(dba.GetListaString);

      });



        app.Run();
    }
}
