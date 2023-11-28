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
    public partial class ConEmp : Form
    {
        private List<Empresa> listaEmpresas = new List<Empresa>();
        public ConEmp()
        {
            InitializeComponent();
            Consultar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            try
            {
                CadEmp formemp = new CadEmp();
                this.Visible = false;
                formemp.ShowDialog();
                this.Visible = true;
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void tabelaFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Consultar()
        {
            try
            {
                var conexao = new Conexao();
                var comando = conexao.Comando("SELECT * FROM Empresa");
                var leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    var empresa = new Empresa();
                    empresa.Id = DAOHelper.GetInt(leitor, "id_emp");
                    empresa.Cnpj = DAOHelper.GetString(leitor, "cnpj_emp");
                    empresa.Razao_Social = DAOHelper.GetString(leitor, "razao_soc_emp");
                    empresa.Nome_fantasia = DAOHelper.GetString(leitor, "nome_fan_emp");
                    empresa.Situacao_Cadastral = DAOHelper.GetString(leitor, "situacao_cad_emp");
                    empresa.Regime_Tributario = DAOHelper.GetString(leitor, "regime_tri_emp");
                    empresa.Data_Inicio = DAOHelper.GetDateTime(leitor, "data_ini_emp");
                    empresa.Telefone = DAOHelper.GetString(leitor, "telefone_emp");
                    empresa.Capital_Social = DAOHelper.GetDouble(leitor, "capital_soc_emp");
                    empresa.Endereco_Completo = DAOHelper.GetString(leitor, "endereco_com_emp");
                    empresa.Tipo = DAOHelper.GetString(leitor, "tipo_emp");
                    empresa.Porte = DAOHelper.GetString(leitor, "porte_emp");
                    empresa.Natureza_Juridica = DAOHelper.GetString(leitor, "natureza_jur_emp");
                    empresa.Nome_Proprietario = DAOHelper.GetString(leitor, "nome_pro_emp");
                    empresa.Cpf_Proprietario = DAOHelper.GetString(leitor, "cpf_pro_emp");
                    listaEmpresas.Add(empresa);
                }

                tabelaEmp.DataSource = listaEmpresas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
