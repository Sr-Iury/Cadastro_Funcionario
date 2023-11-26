using Cadastramento_de_Funcionário.Configuracao;
using Cadastramento_de_Funcionário.Uteis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastramento_de_Funcionário
{
    public partial class ConFunc : Form
    {
        private List<Funcionario> listaFuncionarios = new List<Funcionario>();

        public ConFunc()
        {
            InitializeComponent();
            Consultar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ConFunc con = new ConFunc();
                CadFun func = new CadFun();
                this.Visible = false;
                func.ShowDialog();
                con.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
        public void Consultar()
        {
            try
            {
                var conexao = new Conexao();
                var comando = conexao.Comando("SELECT * FROM Funcionario");
                var leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    var funcionario = new Funcionario();
                    funcionario.Id = DAOHelper.GetInt(leitor, "id_fun");
                    funcionario.Nome = DAOHelper.GetString(leitor, "nome_fun");
                    funcionario.DataNascimento = DAOHelper.GetDateTime(leitor, "data_nas_fun");
                    funcionario.Cpf = DAOHelper.GetString(leitor, "cpf_fun");
                    funcionario.Rg = DAOHelper.GetString(leitor, "rg_fun");
                    funcionario.Telefone = DAOHelper.GetString(leitor, "telefone_fun");
                    funcionario.Email = DAOHelper.GetString(leitor, "email_fun");
                    funcionario.Endereco = DAOHelper.GetString(leitor, "endereco_fun");
                    funcionario.Cidade = DAOHelper.GetString(leitor, "cidade_fun");
                    funcionario.Estado = DAOHelper.GetString(leitor, "estado_fun");
                    funcionario.Funcao = DAOHelper.GetString(leitor, "funcao_fun");
                    funcionario.Salario = DAOHelper.GetDouble(leitor, "salario_fun");
                    listaFuncionarios.Add(funcionario);
                }

                tabelaFunc.DataSource = listaFuncionarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
