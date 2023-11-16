using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Cadastramento_de_Funcionário
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario f = new Funcionario();
                f.Nome = nome.Text;
                f.Cpf = cpf.Text;
                f.Rg = rg.Text;
                f.Telefone = telefone.Text;
                f.Endereco = endereco.Text;
                f.Cidade = cidade.Text;
                f.Estado = estado.Text;
                f.Salario = double.Parse(salario.Text);
                f.Email = gmail.Text;
                f.DataNascimento = Convert.ToDateTime(date.Text);
                if (Validador.Email(f.Email) == true)
                {

                    MessageBox.Show("Email Válido");
                }
                else
                {
                    MessageBox.Show("Email Inválido");
                }
                if(Validacao_CPF.ValidaCPF(f.Cpf) == true)
                {
                    MessageBox.Show("CPF válido");
                }
                else
                {
                    MessageBox.Show("CPF inválido");
                }
                if(f.VerificaCampos(f.Nome, f.DataNascimento, f.Cpf, f.Rg, f.Endereco, f.Cidade, f.Estado, f.Funcao, f.Salario, f.Email, f.Telefone) == true)
                {
                    MessageBox.Show("Adicione um valor, campo em branco");
                }
                else
                {
                    MessageBox.Show("Todos os campos estão preenchidos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
