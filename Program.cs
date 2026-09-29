namespace Projeto_Web_Lh_Pets_Alunos;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Projeto Web – LH Pets
versão 1.");

    app.useStaticFiles();
    app.MapGet("/index",(HTTPContext context) => {
        context.Response.Redirect("/index.html" false);

        app.Run();
    }
}
