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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CadFun form = new CadFun();//Cria uma Instância da classe Começar
            this.Visible = false;//Isso fecha o arquivo quando for abrir o outro
            form.ShowDialog();//No caso ele chama 
            this.Visible = true;//Isso abre o arquivo quando fechado a aba.
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CadFun cadfun = new CadFun();
                this.Visible = false;
                cadfun.ShowDialog();
                this.Visible = true;
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CadEmp cademp = new CadEmp();
                this.Visible = false;
                cademp.ShowDialog();
                this.Visible = true;
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
    }
}
