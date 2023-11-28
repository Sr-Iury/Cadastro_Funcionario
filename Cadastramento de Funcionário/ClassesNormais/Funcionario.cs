using System;
public class Funcionario {
    public int Id { get; set; } 
    public string Nome { get; set; }
    public DateTime? DataNascimento { get; set; }
    public string Cpf { get; set; }
    public string Rg { get; set; }
    public string Endereco {get; set;}
    public string Cidade { get; set;}
    public string Estado { get; set;}
    public string Funcao { get; set;}
    public string Telefone { get; set;}
    public double Salario { get; set;}
    public string Email { get; set;}
    public string EstadoCivil { get; set;}

    public Funcionario()
    {

    }

    public Funcionario(string nome, DateTime? data, string cpf, string rg, string endereco, string cidade, string estado, string funcao, double salario, string email, string telefone, string estadoCivil)
    {
        nome = this.Nome;
        data = this.DataNascimento;
        cpf = this.Cpf;
        rg = this.Rg;
        endereco = this.Endereco;
        cidade = this.Cidade;
        estado = this.Estado;
        funcao = this.Funcao;
        salario = this.Salario;
        email = this.Email;
        telefone = this.Telefone;
        estadoCivil = this.EstadoCivil;
    }

}


