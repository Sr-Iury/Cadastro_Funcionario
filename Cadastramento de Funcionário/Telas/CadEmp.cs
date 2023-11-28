using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastramento_de_Funcionário.Configuracao;
using CpfCnpjLibrary;

namespace Cadastramento_de_Funcionário
{
    public partial class CadEmp : Form
    {
        public CadEmp()
        {
            InitializeComponent();
        }

        void inserir(Empresa empresa)
        {
            try
            {
                Conexao conexao = new Conexao(); 

                var comando = conexao.Comando("INSERT INTO Empresa VALUES (null, @cnpj, @razao_social, @nome_fantasia, @situacao_cadastral, @regime_tributario, @data_inicial, @telefone, @capital_social, @endereco_completo, @tipo, @porte, @natureza_juridica, @nome_proprietario, @cpf_proprietario)");

                comando.Parameters.AddWithValue("null", empresa.Id);
                comando.Parameters.AddWithValue("@cnpj", empresa.Cnpj);
                comando.Parameters.AddWithValue("@razao_social", empresa.Razao_Social);
                comando.Parameters.AddWithValue("@nome_fantasia", empresa.Nome_fantasia);
                comando.Parameters.AddWithValue("@situacao_cadastral", empresa.Situacao_Cadastral);
                comando.Parameters.AddWithValue("@regime_tributario", empresa.Regime_Tributario);
                comando.Parameters.AddWithValue("@data_inicial", empresa.Data_Inicio);
                comando.Parameters.AddWithValue("@telefone", empresa.Telefone);
                comando.Parameters.AddWithValue("@capital_social", empresa.Capital_Social);
                comando.Parameters.AddWithValue("endereco_completo", empresa.Endereco_Completo);
                comando.Parameters.AddWithValue("@tipo", empresa.Tipo);
                comando.Parameters.AddWithValue("@porte", empresa.Porte);
                comando.Parameters.AddWithValue("@natureza_juridica", empresa.Natureza_Juridica);
                comando.Parameters.AddWithValue("@nome_proprietario", empresa.Nome_Proprietario);
                comando.Parameters.AddWithValue("@cpf_proprietario", empresa.Cpf_Proprietario);

                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Empresa cadastrada com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado" + ex);
            }

        }

        private void LimparTextBoxs()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is MaskedTextBox || control is DateTimePicker)
                {
                    control.Text = string.Empty;
                }
            }
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

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                Empresa emp = new Empresa();
                emp.Razao_Social = razao_social.Text;
                emp.Nome_fantasia = nome_fantasia.Text;
                emp.Situacao_Cadastral = situacao_cadastral.Text;
                emp.Data_Inicio = Convert.ToDateTime(data.Text);
                emp.Telefone = telefone.Text;
                emp.Capital_Social = Convert.ToDouble(capital_social.Text);
                emp.Endereco_Completo = endereco_completo.Text;
                emp.Natureza_Juridica = natureza_juridica.Text;
                emp.Nome_Proprietario = nome_proprietario.Text;
                emp.Cpf_Proprietario = cpf_proprietario.Text;

                if(matriz.Checked == true) { 
                emp.Tipo = matriz.Text;
                }
                else
                {
                    emp.Tipo = filial.Text;
                }

                if(pequeno.Checked == true)
                {
                    emp.Porte= pequeno.Text;
                }
                else if(medio.Checked == true)
                {
                    emp.Porte = medio.Text;
                }
                else if (grande.Checked == true)
                {
                    emp.Porte = grande.Text;
                }

                if(simples.Checked== true) { 
                    emp.Regime_Tributario = simples.Text;
                }
                else if (lucro.Checked == true)
                {
                    emp.Regime_Tributario = lucro.Text;
                }
                else if (real.Checked == true)
                {
                    emp.Regime_Tributario = real.Text;
                }
                emp.Cnpj = cnpj.Text;
                Cnpj.Validar(emp.Cnpj);
                if (ExistemTextBoxsVazios() == true)
                {
                    MessageBox.Show("Todos os campos são obrigatórios. Por favor preencher os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (Cnpj.Validar(emp.Cnpj) == false)
                {
                    MessageBox.Show("CNPJ inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(Validador.CPF(emp.Cpf_Proprietario) == false)
                {
                    MessageBox.Show("CFF inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    inserir(emp);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ConEmp comemp = new ConEmp();
                this.Visible = false;
                comemp.ShowDialog();
                this.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                Menu formfun = new Menu();
                this.Visible = false;
                formfun.ShowDialog();
                this.Visible = true;
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparTextBoxs();
            cnpj.Clear();
            razao_social.Clear();
            nome_fantasia.Clear();
            telefone.Clear();
            capital_social.Clear();
            nome_proprietario.Clear();
            cpf_proprietario.Clear();
        }

        private void CadEmp_Load(object sender, EventArgs e)
        {

        }
    }
}
