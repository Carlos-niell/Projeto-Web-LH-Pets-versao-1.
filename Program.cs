using Projeto_Web_Lh_Pets_Alunos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var banco = new Banco();

app.UseStaticFiles();

app.MapGet("/", () => "LH Pets - Protótipo 1");

app.MapGet("/index", () => Results.Redirect("/index.html"));

app.MapGet("/listaClientes", () => Results.Content(banco.GetListaString(), "text/html"));

app.Run();
