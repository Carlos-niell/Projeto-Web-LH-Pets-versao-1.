using System.Data.SqlClient;
using System.Text;

namespace Projeto_Web_Lh_Pets_Alunos;

public class Banco
{
    public List<Clientes> lista { get; private set; }

    public Banco()
    {
        lista = new List<Clientes>();

        try
        {
            var connectionString = new SqlConnectionStringBuilder
            {
                UserID = "sa",
                Password = "12345",
                DataSource = @"localhost\SQLEXPRESS",
                InitialCatalog = "vendas",
                IntegratedSecurity = false
            }.ConnectionString;

            using var conexao = new SqlConnection(connectionString);
            const string sql = "SELECT * FROM tblclientes";
            using var comando = new SqlCommand(sql, conexao);

            conexao.Open();
            using var tabela = comando.ExecuteReader();

            while (tabela.Read())
            {
                lista.Add(new Clientes
                {
                    cpf_cnpj = tabela["cpf_cnpj"]?.ToString() ?? string.Empty,
                    nome = tabela["nome"]?.ToString() ?? string.Empty,
                    endereco = tabela["endereco"]?.ToString() ?? string.Empty,
                    rg_ie = tabela["rg_ie"]?.ToString() ?? string.Empty,
                    tipo = tabela["tipo"]?.ToString() ?? string.Empty,
                    valor = Convert.ToSingle(tabela["valor"]),
                    valor_imposto = Convert.ToSingle(tabela["valor_imposto"]),
                    total = Convert.ToSingle(tabela["total"])
                });
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao carregar clientes: {ex.Message}");

            lista = new List<Clientes>
            {
                new Clientes { cpf_cnpj = "123.456.789-00", nome = "Pedro da Silva", endereco = "Rua Vergueiro 1234", rg_ie = "4.567.890", tipo = "f", valor = 2500, valor_imposto = 250, total = 2750 },
                new Clientes { cpf_cnpj = "234.567.890-11", nome = "Maria Pereira", endereco = "Rua São Bento 345", rg_ie = "5.6787.901", tipo = "f", valor = 3000, valor_imposto = 300, total = 3300 },
                new Clientes { cpf_cnpj = "56.789.123/0001-00", nome = "Virtual Tecnologia S/A", endereco = "Av. Brasil 3456", rg_ie = "567.890.123", tipo = "j", valor = 35000, valor_imposto = 7000, total = 42000 }
            };
        }
    }

    public List<Clientes> GetLista()
    {
        return lista;
    }

    public string GetListaString()
    {
        var html = new StringBuilder();
        html.AppendLine("<!DOCTYPE html>");
        html.AppendLine("<html>");
        html.AppendLine("<head>");
        html.AppendLine("<meta charset='utf-8' />");
        html.AppendLine("<title>Cadastro de Clientes</title>");
        html.AppendLine("</head>");
        html.AppendLine("<body>");
        html.AppendLine("<h2>Lista de Clientes</h2>");
        html.AppendLine("<table border='1' cellpadding='8' cellspacing='0'>");
        html.AppendLine("<tr><th>CPF/CNPJ</th><th>Nome</th><th>Endereço</th><th>RG/IE</th><th>Tipo</th><th>Valor</th><th>Imposto</th><th>Total</th></tr>");

        foreach (var cli in lista)
        {
            html.AppendLine($"<tr><td>{cli.cpf_cnpj}</td><td>{cli.nome}</td><td>{cli.endereco}</td><td>{cli.rg_ie}</td><td>{cli.tipo}</td><td>{cli.valor:C}</td><td>{cli.valor_imposto:C}</td><td>{cli.total:C}</td></tr>");
        }

        html.AppendLine("</table>");
        html.AppendLine("</body>");
        html.AppendLine("</html>");

        return html.ToString();
    }

    public void imprimirListaConsole()
    {
        Console.WriteLine("CPF / CNPJ - Nome - Endereço - RG / IE - Tipo - Valor - Valor Imposto - Total");

        foreach (var cli in lista)
        {
            Console.WriteLine($"{cli.cpf_cnpj} - {cli.nome} - {cli.endereco} - {cli.rg_ie} - {cli.tipo} - {cli.valor:C} - {cli.valor_imposto:C} - {cli.total:C}");
        }
    }
}