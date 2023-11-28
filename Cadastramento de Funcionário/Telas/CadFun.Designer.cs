namespace Cadastramento_de_Funcionário
{
    partial class CadFun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadFun));
            this.date = new System.Windows.Forms.DateTimePicker();
            this.nome = new System.Windows.Forms.TextBox();
            this.rg = new System.Windows.Forms.TextBox();
            this.endereco = new System.Windows.Forms.TextBox();
            this.cidade = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.TextBox();
            this.gmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.salario = new System.Windows.Forms.MaskedTextBox();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.funcao = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(295, 149);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(207, 20);
            this.date.TabIndex = 5;
            // 
            // nome
            // 
            this.nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nome.Location = new System.Drawing.Point(302, 83);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(179, 13);
            this.nome.TabIndex = 0;
            // 
            // rg
            // 
            this.rg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rg.Location = new System.Drawing.Point(301, 268);
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(179, 13);
            this.rg.TabIndex = 3;
            // 
            // endereco
            // 
            this.endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.endereco.Location = new System.Drawing.Point(551, 67);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(179, 13);
            this.endereco.TabIndex = 6;
            // 
            // cidade
            // 
            this.cidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cidade.Location = new System.Drawing.Point(551, 116);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(179, 13);
            this.cidade.TabIndex = 7;
            // 
            // estado
            // 
            this.estado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.estado.Location = new System.Drawing.Point(550, 167);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(179, 13);
            this.estado.TabIndex = 8;
            // 
            // gmail
            // 
            this.gmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gmail.Location = new System.Drawing.Point(551, 330);
            this.gmail.Name = "gmail";
            this.gmail.Size = new System.Drawing.Size(179, 13);
            this.gmail.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(288, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(574, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 19);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(534, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 42);
            this.button3.TabIndex = 14;
            this.button3.Text = "SALVAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.salario);
            this.panel1.Controls.Add(this.telefone);
            this.panel1.Controls.Add(this.cpf);
            this.panel1.Controls.Add(this.funcao);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.gmail);
            this.panel1.Controls.Add(this.estado);
            this.panel1.Controls.Add(this.cidade);
            this.panel1.Controls.Add(this.endereco);
            this.panel1.Controls.Add(this.rg);
            this.panel1.Controls.Add(this.nome);
            this.panel1.Controls.Add(this.date);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // salario
            // 
            this.salario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salario.Location = new System.Drawing.Point(550, 267);
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(177, 13);
            this.salario.TabIndex = 19;
            // 
            // telefone
            // 
            this.telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefone.Location = new System.Drawing.Point(302, 327);
            this.telefone.Mask = "(00) 00000-0000";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(178, 13);
            this.telefone.TabIndex = 18;
            // 
            // cpf
            // 
            this.cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cpf.Location = new System.Drawing.Point(303, 211);
            this.cpf.Mask = "000,000,000-00";
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(178, 13);
            this.cpf.TabIndex = 17;
            // 
            // funcao
            // 
            this.funcao.FormattingEnabled = true;
            this.funcao.Items.AddRange(new object[] {
            "Professor",
            "Supervisor",
            "Orientadora",
            "Diretora"});
            this.funcao.Location = new System.Drawing.Point(543, 212);
            this.funcao.Name = "funcao";
            this.funcao.Size = new System.Drawing.Size(197, 21);
            this.funcao.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(15, 432);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 42);
            this.button4.TabIndex = 19;
            this.button4.Text = "VOLTAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(581, 434);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 42);
            this.button5.TabIndex = 20;
            this.button5.Text = "CONSULTAR FUNCIONÁRIOS";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CadFun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(856, 488);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Name = "CadFun";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox rg;
        private System.Windows.Forms.TextBox endereco;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.TextBox gmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox funcao;
        private System.Windows.Forms.MaskedTextBox telefone;
        private System.Windows.Forms.MaskedTextBox cpf;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MaskedTextBox salario;
    }
}