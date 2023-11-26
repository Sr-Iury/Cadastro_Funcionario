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
using MySql.Data.MySqlClient;
using Cadastramento_de_Funcionário.Configuracao;
using System.Security.Cryptography.X509Certificates;
using Cadastramento_de_Funcionário.Uteis;

namespace Cadastramento_de_Funcionário
{
    public partial class CadFun : Form
    {
        private List<Funcionario> listaFuncionarios = new List<Funcionario>();
        public CadFun()
        {
            InitializeComponent();
            List<Funcionario> func = new List<Funcionario>();
        }
        void inserir(Funcionario funcionario)
        {
            try
            {
                Conexao conexao = new Conexao();

                var comando = conexao.Comando("INSERT INTO Funcionario VALUES (null, @nome, @data, @cpf, @rg, @telefone, @email, @endereco, @cidade, @estado, @funcao, @salario)");

                comando.Parameters.AddWithValue("null", funcionario.Id);
                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@data", funcionario.DataNascimento);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@rg", funcionario.Rg);
                comando.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                comando.Parameters.AddWithValue("email", funcionario.Email);
                comando.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                comando.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                comando.Parameters.AddWithValue("@estado", funcionario.Estado);
                comando.Parameters.AddWithValue("@funcao", funcionario.Funcao);
                comando.Parameters.AddWithValue("@salario", funcionario.Salario);

                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado" + ex);
            }

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LimparTextBoxs()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is MaskedTextBox || control is DateTimePicker)
                {
                    control.Text =  string.Empty;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparTextBoxs();
            MessageBox.Show("TEXTBOX LIMPOS");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private bool ExistemTextBoxsVazios()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is MaskedTextBox || control is DateTimePicker)
                {
                    var text = control.Text.Replace(",", "").Replace("-", "").Trim();

                    if (text == "")
                    {
                        return true;
                    }
                }
            }
            return false;
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
                if (ExistemTextBoxsVazios() == true)
                {
                    MessageBox.Show("Todos os campos são obrigatórios. Por favor preencher os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (Validacao_CPF.ValidaCPF(f.Cpf) == false)
                {
                    MessageBox.Show("CPF inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Validador.Email(f.Email) == false)
                {
                    MessageBox.Show("Email inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    inserir(f);
                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            


        }       

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                CadFun cadfun = new CadFun();
                Menu men = new Menu();
                this.Visible = false;
                men.ShowDialog();
                cadfun.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                CadFun cadfun = new CadFun();
                ConFunc consulta = new ConFunc();
                this.Visible = false;
                consulta.ShowDialog();
                cadfun.Close();
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }

        }
    }
}
