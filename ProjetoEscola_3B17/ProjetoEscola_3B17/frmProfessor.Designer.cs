namespace ProjetoEscola_3B17
{
    partial class frmProfessor
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
            this.dtgProfessor = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.dtpDtAdmissao = new System.Windows.Forms.DateTimePicker();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.lbldiscplina = new System.Windows.Forms.Label();
            this.lblCargaHoraria = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblDataDeAdmissao = new System.Windows.Forms.Label();
            this.lblProf = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbxdisciplina = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cbxescolaridade = new System.Windows.Forms.ComboBox();
            this.Escolaridade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgProfessor
            // 
            this.dtgProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProfessor.Location = new System.Drawing.Point(11, 264);
            this.dtgProfessor.Name = "dtgProfessor";
            this.dtgProfessor.Size = new System.Drawing.Size(573, 150);
            this.dtgProfessor.TabIndex = 0;
            this.dtgProfessor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProfessor_CellClick);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(21, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(201, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(383, 102);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(201, 20);
            this.txtSalario.TabIndex = 3;
            // 
            // dtpDtAdmissao
            // 
            this.dtpDtAdmissao.Location = new System.Drawing.Point(382, 159);
            this.dtpDtAdmissao.Name = "dtpDtAdmissao";
            this.dtpDtAdmissao.Size = new System.Drawing.Size(200, 20);
            this.dtpDtAdmissao.TabIndex = 4;
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Location = new System.Drawing.Point(380, 43);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(201, 20);
            this.txtCargaHoraria.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCadastrar.Location = new System.Drawing.Point(11, 466);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(122, 42);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Turquoise;
            this.btnUpdate.Location = new System.Drawing.Point(165, 466);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 42);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(316, 466);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 42);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSair.Location = new System.Drawing.Point(462, 466);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(122, 42);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(21, 86);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(35, 13);
            this.lblnome.TabIndex = 10;
            this.lblnome.Text = "Nome";
            // 
            // lbldiscplina
            // 
            this.lbldiscplina.AutoSize = true;
            this.lbldiscplina.Location = new System.Drawing.Point(21, 142);
            this.lbldiscplina.Name = "lbldiscplina";
            this.lbldiscplina.Size = new System.Drawing.Size(52, 13);
            this.lbldiscplina.TabIndex = 11;
            this.lbldiscplina.Text = "Disciplina";
            // 
            // lblCargaHoraria
            // 
            this.lblCargaHoraria.AutoSize = true;
            this.lblCargaHoraria.Location = new System.Drawing.Point(380, 27);
            this.lblCargaHoraria.Name = "lblCargaHoraria";
            this.lblCargaHoraria.Size = new System.Drawing.Size(116, 13);
            this.lblCargaHoraria.TabIndex = 12;
            this.lblCargaHoraria.Text = "Carga Horária Semanal";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(380, 86);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 13;
            this.lblSalario.Text = "Salário";
            // 
            // lblDataDeAdmissao
            // 
            this.lblDataDeAdmissao.AutoSize = true;
            this.lblDataDeAdmissao.Location = new System.Drawing.Point(380, 142);
            this.lblDataDeAdmissao.Name = "lblDataDeAdmissao";
            this.lblDataDeAdmissao.Size = new System.Drawing.Size(93, 13);
            this.lblDataDeAdmissao.TabIndex = 14;
            this.lblDataDeAdmissao.Text = "Data de Admissao";
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProf.Location = new System.Drawing.Point(246, 9);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(104, 25);
            this.lblProf.TabIndex = 15;
            this.lblProf.Text = "Professor";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(21, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(21, 46);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(201, 20);
            this.txtId.TabIndex = 16;
            // 
            // cbxdisciplina
            // 
            this.cbxdisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxdisciplina.FormattingEnabled = true;
            this.cbxdisciplina.Items.AddRange(new object[] {
            "POO",
            "BD2",
            "TPA",
            "MATEMATICA",
            "PORTUGUES",
            "EMPREENDEDORISMO",
            "FILOSOFIA",
            "RAAC",
            "FISICA"});
            this.cbxdisciplina.Location = new System.Drawing.Point(21, 162);
            this.cbxdisciplina.Name = "cbxdisciplina";
            this.cbxdisciplina.Size = new System.Drawing.Size(201, 21);
            this.cbxdisciplina.TabIndex = 18;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnLimpar.Location = new System.Drawing.Point(464, 422);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(122, 42);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cbxescolaridade
            // 
            this.cbxescolaridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxescolaridade.FormattingEnabled = true;
            this.cbxescolaridade.Location = new System.Drawing.Point(217, 228);
            this.cbxescolaridade.Name = "cbxescolaridade";
            this.cbxescolaridade.Size = new System.Drawing.Size(201, 21);
            this.cbxescolaridade.TabIndex = 21;
            // 
            // Escolaridade
            // 
            this.Escolaridade.AutoSize = true;
            this.Escolaridade.Location = new System.Drawing.Point(217, 208);
            this.Escolaridade.Name = "Escolaridade";
            this.Escolaridade.Size = new System.Drawing.Size(68, 13);
            this.Escolaridade.TabIndex = 20;
            this.Escolaridade.Text = "Escolaridade";
            // 
            // frmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 536);
            this.Controls.Add(this.cbxescolaridade);
            this.Controls.Add(this.Escolaridade);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cbxdisciplina);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.lblDataDeAdmissao);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblCargaHoraria);
            this.Controls.Add(this.lbldiscplina);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtCargaHoraria);
            this.Controls.Add(this.dtpDtAdmissao);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dtgProfessor);
            this.Name = "frmProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Professor";
            this.Load += new System.EventHandler(this.frmProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfessor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProfessor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.DateTimePicker dtpDtAdmissao;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lbldiscplina;
        private System.Windows.Forms.Label lblCargaHoraria;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblDataDeAdmissao;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cbxdisciplina;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cbxescolaridade;
        private System.Windows.Forms.Label Escolaridade;
    }
}

