namespace Projeto_Web_Lh_Pets_Alunos;

public class Clientes
{
    public string? cpf_cnpj { get; set; }
    public string nome { get; set; } = string.Empty;
    public string endereco { get; set; } = string.Empty;
    public string rg_ie { get; set; } = string.Empty;
    public string tipo { get; set; } = string.Empty;
    public float valor { get; set; }
    public float valor_imposto { get; set; }
    public float total { get; set; }
}