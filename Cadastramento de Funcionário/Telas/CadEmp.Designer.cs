namespace Cadastramento_de_Funcionário
{
    partial class CadEmp
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadEmp));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cnpj = new System.Windows.Forms.MaskedTextBox();
            this.razao_social = new System.Windows.Forms.TextBox();
            this.nome_fantasia = new System.Windows.Forms.TextBox();
            this.situacao_cadastral = new System.Windows.Forms.ComboBox();
            this.simples = new System.Windows.Forms.RadioButton();
            this.lucro = new System.Windows.Forms.RadioButton();
            this.real = new System.Windows.Forms.RadioButton();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.capital_social = new System.Windows.Forms.TextBox();
            this.endereco_completo = new System.Windows.Forms.ComboBox();
            this.natureza_juridica = new System.Windows.Forms.ComboBox();
            this.nome_proprietario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cpf_proprietario = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.filial = new System.Windows.Forms.RadioButton();
            this.matriz = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grande = new System.Windows.Forms.RadioButton();
            this.medio = new System.Windows.Forms.RadioButton();
            this.pequeno = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "OLI.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "CADASTRO DE EMPRESA";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(581, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 42);
            this.button3.TabIndex = 29;
            this.button3.Text = "SALVAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(355, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 42);
            this.button1.TabIndex = 27;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cnpj
            // 
            this.cnpj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cnpj.Location = new System.Drawing.Point(320, 69);
            this.cnpj.Mask = "00,000,000/0000-00";
            this.cnpj.Name = "cnpj";
            this.cnpj.Size = new System.Drawing.Size(146, 13);
            this.cnpj.TabIndex = 31;
            // 
            // razao_social
            // 
            this.razao_social.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.razao_social.Location = new System.Drawing.Point(319, 112);
            this.razao_social.Name = "razao_social";
            this.razao_social.Size = new System.Drawing.Size(146, 13);
            this.razao_social.TabIndex = 32;
            // 
            // nome_fantasia
            // 
            this.nome_fantasia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nome_fantasia.Location = new System.Drawing.Point(319, 147);
            this.nome_fantasia.Name = "nome_fantasia";
            this.nome_fantasia.Size = new System.Drawing.Size(146, 13);
            this.nome_fantasia.TabIndex = 33;
            // 
            // situacao_cadastral
            // 
            this.situacao_cadastral.FormattingEnabled = true;
            this.situacao_cadastral.Items.AddRange(new object[] {
            "Ativa",
            "Nula",
            "Suspensa",
            "Inapta",
            "Baixada"});
            this.situacao_cadastral.Location = new System.Drawing.Point(319, 190);
            this.situacao_cadastral.Name = "situacao_cadastral";
            this.situacao_cadastral.Size = new System.Drawing.Size(146, 21);
            this.situacao_cadastral.TabIndex = 34;
            // 
            // simples
            // 
            this.simples.AutoSize = true;
            this.simples.Location = new System.Drawing.Point(2, 14);
            this.simples.Name = "simples";
            this.simples.Size = new System.Drawing.Size(114, 17);
            this.simples.TabIndex = 35;
            this.simples.Text = "Situação Tributária";
            this.simples.UseVisualStyleBackColor = true;
            // 
            // lucro
            // 
            this.lucro.AutoSize = true;
            this.lucro.Location = new System.Drawing.Point(120, 12);
            this.lucro.Name = "lucro";
            this.lucro.Size = new System.Drawing.Size(104, 17);
            this.lucro.TabIndex = 36;
            this.lucro.Text = "Lucro Presumido";
            this.lucro.UseVisualStyleBackColor = true;
            // 
            // real
            // 
            this.real.AutoSize = true;
            this.real.Location = new System.Drawing.Point(229, 14);
            this.real.Name = "real";
            this.real.Size = new System.Drawing.Size(47, 17);
            this.real.TabIndex = 37;
            this.real.Text = "Real";
            this.real.UseVisualStyleBackColor = true;
            // 
            // telefone
            // 
            this.telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefone.Location = new System.Drawing.Point(319, 280);
            this.telefone.Mask = "(00) 00000-0000";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(146, 13);
            this.telefone.TabIndex = 39;
            // 
            // capital_social
            // 
            this.capital_social.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.capital_social.Location = new System.Drawing.Point(320, 321);
            this.capital_social.Name = "capital_social";
            this.capital_social.Size = new System.Drawing.Size(144, 13);
            this.capital_social.TabIndex = 40;
            // 
            // endereco_completo
            // 
            this.endereco_completo.FormattingEnabled = true;
            this.endereco_completo.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.endereco_completo.Location = new System.Drawing.Point(318, 360);
            this.endereco_completo.Name = "endereco_completo";
            this.endereco_completo.Size = new System.Drawing.Size(146, 21);
            this.endereco_completo.TabIndex = 41;
            // 
            // natureza_juridica
            // 
            this.natureza_juridica.FormattingEnabled = true;
            this.natureza_juridica.Items.AddRange(new object[] {
            "EI – Empresário Individual",
            "MEI – Microempreendedor Individual",
            "Sociedade Anônima",
            "Sociedade Simples Limitada",
            "Sociedade Limitada Unipessoa"});
            this.natureza_juridica.Location = new System.Drawing.Point(493, 172);
            this.natureza_juridica.Name = "natureza_juridica";
            this.natureza_juridica.Size = new System.Drawing.Size(276, 21);
            this.natureza_juridica.TabIndex = 47;
            // 
            // nome_proprietario
            // 
            this.nome_proprietario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nome_proprietario.Location = new System.Drawing.Point(493, 218);
            this.nome_proprietario.Name = "nome_proprietario";
            this.nome_proprietario.Size = new System.Drawing.Size(276, 13);
            this.nome_proprietario.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Cnpj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Razão Social";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Nome Fantasia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Situação Cadastral";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Data de Início de Atividade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(316, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Telefone ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Capital Social";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(317, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Endereço Completo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(494, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 61;
            this.label13.Text = "Natureza Jurídica";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(490, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 13);
            this.label14.TabIndex = 62;
            this.label14.Text = "Nome do Proprietário";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(490, 264);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 63;
            this.label15.Text = "CPF do Proprietário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(318, 240);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(148, 20);
            this.data.TabIndex = 65;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(355, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 42);
            this.button2.TabIndex = 66;
            this.button2.Text = "VOLTAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(581, 444);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 42);
            this.button5.TabIndex = 64;
            this.button5.Text = "CONSULTAR EMPRESA";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cpf_proprietario
            // 
            this.cpf_proprietario.Location = new System.Drawing.Point(493, 284);
            this.cpf_proprietario.Mask = "000,000,000-00";
            this.cpf_proprietario.Name = "cpf_proprietario";
            this.cpf_proprietario.Size = new System.Drawing.Size(195, 20);
            this.cpf_proprietario.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "Tipo";
            // 
            // filial
            // 
            this.filial.AutoSize = true;
            this.filial.Location = new System.Drawing.Point(20, 24);
            this.filial.Name = "filial";
            this.filial.Size = new System.Drawing.Size(42, 17);
            this.filial.TabIndex = 68;
            this.filial.TabStop = true;
            this.filial.Text = "filial";
            this.filial.UseVisualStyleBackColor = true;
            // 
            // matriz
            // 
            this.matriz.AutoSize = true;
            this.matriz.Location = new System.Drawing.Point(80, 24);
            this.matriz.Name = "matriz";
            this.matriz.Size = new System.Drawing.Size(52, 17);
            this.matriz.TabIndex = 69;
            this.matriz.TabStop = true;
            this.matriz.Text = "matriz";
            this.matriz.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.grande);
            this.groupBox2.Controls.Add(this.medio);
            this.groupBox2.Controls.Add(this.pequeno);
            this.groupBox2.Location = new System.Drawing.Point(488, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 41);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 60;
            this.label12.Text = "Porte da Empresa";
            // 
            // grande
            // 
            this.grande.AutoSize = true;
            this.grande.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.grande.Location = new System.Drawing.Point(201, 17);
            this.grande.Name = "grande";
            this.grande.Size = new System.Drawing.Size(60, 17);
            this.grande.TabIndex = 46;
            this.grande.Text = "Grande";
            this.grande.UseVisualStyleBackColor = true;
            // 
            // medio
            // 
            this.medio.AutoSize = true;
            this.medio.Location = new System.Drawing.Point(110, 17);
            this.medio.Name = "medio";
            this.medio.Size = new System.Drawing.Size(54, 17);
            this.medio.TabIndex = 45;
            this.medio.Text = "Médio";
            this.medio.UseVisualStyleBackColor = true;
            // 
            // pequeno
            // 
            this.pequeno.AutoSize = true;
            this.pequeno.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.pequeno.Location = new System.Drawing.Point(10, 17);
            this.pequeno.Name = "pequeno";
            this.pequeno.Size = new System.Drawing.Size(68, 17);
            this.pequeno.TabIndex = 44;
            this.pequeno.Text = "Pequeno";
            this.pequeno.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.matriz);
            this.groupBox1.Controls.Add(this.filial);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(488, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 49);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.real);
            this.groupBox3.Controls.Add(this.lucro);
            this.groupBox3.Controls.Add(this.simples);
            this.groupBox3.Location = new System.Drawing.Point(488, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 46);
            this.groupBox3.TabIndex = 74;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Regime Tributário";
            // 
            // CadEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(868, 498);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cpf_proprietario);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.data);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nome_proprietario);
            this.Controls.Add(this.natureza_juridica);
            this.Controls.Add(this.endereco_completo);
            this.Controls.Add(this.capital_social);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.situacao_cadastral);
            this.Controls.Add(this.nome_fantasia);
            this.Controls.Add(this.razao_social);
            this.Controls.Add(this.cnpj);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "CadEmp";
            this.Text = "s";
            this.Load += new System.EventHandler(this.CadEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox cnpj;
        private System.Windows.Forms.TextBox razao_social;
        private System.Windows.Forms.TextBox nome_fantasia;
        private System.Windows.Forms.ComboBox situacao_cadastral;
        private System.Windows.Forms.RadioButton simples;
        private System.Windows.Forms.RadioButton lucro;
        private System.Windows.Forms.RadioButton real;
        private System.Windows.Forms.MaskedTextBox telefone;
        private System.Windows.Forms.TextBox capital_social;
        private System.Windows.Forms.ComboBox endereco_completo;
        private System.Windows.Forms.ComboBox natureza_juridica;
        private System.Windows.Forms.TextBox nome_proprietario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MaskedTextBox cpf_proprietario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton filial;
        private System.Windows.Forms.RadioButton matriz;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton grande;
        private System.Windows.Forms.RadioButton medio;
        private System.Windows.Forms.RadioButton pequeno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

