using System;
public class Empresa
{
    public int Id { get; set; }
    public string Cnpj { get; set; }
    public string Razao_Social { get; set; }
    public string Nome_fantasia { get; set; }
    public string Situacao_Cadastral { get; set; }
    public string Regime_Tributario { get; set; }
    public DateTime? Data_Inicio { get; set; }
    public string Telefone { get; set; }
    public string Capital_Social { get; set; }
    public string Endereco_Completo { get; set; }
    public string Tipo { get; set; }
    public string Porte { get; set; }
    public string Natureza_Juridica { get; set; }
    public string Nome_Proprietario { get; set; }
    public string Cpf_Proprietario { get; set; }

    public Empresa()
    {

    }

    public Empresa(string Razao_Social, string Situacao_Cadastral, string Nome_fantasia, string Regime_Tributario, DateTime? Data_Inicio, string Telefone, string Capital_Social, string Endereco_Completo, string Tipo, string Porte, string Natureza_Juridica, string Nome_Proprietario, string Cpf_Proprietario, string cnpj)
    {
        Razao_Social = this.Razao_Social;
        Situacao_Cadastral = this.Situacao_Cadastral;
        Nome_fantasia = this.Nome_fantasia;
        Regime_Tributario = this.Regime_Tributario;
        Data_Inicio = this.Data_Inicio;
        Telefone = this.Telefone;
        Capital_Social = this.Capital_Social;
        Endereco_Completo = this.Endereco_Completo;
        Tipo = this.Tipo;
        Porte = this.Porte;
        Natureza_Juridica = this.Natureza_Juridica;
        Nome_Proprietario = this.Nome_Proprietario;
        Cpf_Proprietario = this.Cpf_Proprietario;
        cnpj = this.Cnpj;
    }
    public bool VerificaCampos(string nome, DateTime data, string cpf, string rg, string endereco, string cidade, string estado, string funcao, double salario, string email, string telefone)
    {
        if (nome == null || data == null || rg == null || endereco == null || cidade == null || estado == null || funcao == null || salario == null || email == null || telefone == null)
        {
            return false;
        }
        return true;
    }

}



