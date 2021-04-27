namespace ProjetoEscola_3B17
{
    partial class frmAluno
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblProf = new System.Windows.Forms.Label();
            this.lblDataDeNascimento = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dtpDtNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtNomes = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.dtgAluno = new System.Windows.Forms.DataGridView();
            this.cbxserie = new System.Windows.Forms.ComboBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemino = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxcurso = new System.Windows.Forms.ComboBox();
            this.lblcurso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(31, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 35;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(31, 46);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(201, 20);
            this.txtId.TabIndex = 34;
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProf.Location = new System.Drawing.Point(268, 15);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(67, 25);
            this.lblProf.TabIndex = 33;
            this.lblProf.Text = "Aluno";
            // 
            // lblDataDeNascimento
            // 
            this.lblDataDeNascimento.AutoSize = true;
            this.lblDataDeNascimento.Location = new System.Drawing.Point(387, 145);
            this.lblDataDeNascimento.Name = "lblDataDeNascimento";
            this.lblDataDeNascimento.Size = new System.Drawing.Size(104, 13);
            this.lblDataDeNascimento.TabIndex = 32;
            this.lblDataDeNascimento.Text = "Data de Nascimento";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(390, 86);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(31, 13);
            this.lblsexo.TabIndex = 31;
            this.lblsexo.Text = "Sexo";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(390, 27);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(31, 13);
            this.lblSerie.TabIndex = 30;
            this.lblSerie.Text = "Série";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(31, 145);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 29;
            this.lblNome.Text = "Nome";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(31, 86);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(50, 13);
            this.lblMatricula.TabIndex = 28;
            this.lblMatricula.Text = "Matricula";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(469, 442);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(122, 42);
            this.btnSair.TabIndex = 27;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(323, 442);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 42);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(172, 442);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 42);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(18, 442);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(122, 42);
            this.btnCadastrar.TabIndex = 24;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dtpDtNascimento
            // 
            this.dtpDtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtNascimento.Location = new System.Drawing.Point(390, 161);
            this.dtpDtNascimento.Name = "dtpDtNascimento";
            this.dtpDtNascimento.Size = new System.Drawing.Size(200, 20);
            this.dtpDtNascimento.TabIndex = 22;
            // 
            // txtNomes
            // 
            this.txtNomes.Location = new System.Drawing.Point(31, 161);
            this.txtNomes.Name = "txtNomes";
            this.txtNomes.Size = new System.Drawing.Size(201, 20);
            this.txtNomes.TabIndex = 20;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(31, 105);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(201, 20);
            this.txtMatricula.TabIndex = 19;
            // 
            // dtgAluno
            // 
            this.dtgAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAluno.Location = new System.Drawing.Point(18, 241);
            this.dtgAluno.Name = "dtgAluno";
            this.dtgAluno.Size = new System.Drawing.Size(573, 150);
            this.dtgAluno.TabIndex = 18;
            this.dtgAluno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAluno_CellClick);
            // 
            // cbxserie
            // 
            this.cbxserie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxserie.FormattingEnabled = true;
            this.cbxserie.Items.AddRange(new object[] {
            "1A2",
            "1B2",
            "1C2",
            "1D2",
            "2A2",
            "2B2",
            "2C2",
            "2D2",
            "3A2",
            "3B2",
            "3C2"});
            this.cbxserie.Location = new System.Drawing.Point(390, 46);
            this.cbxserie.Name = "cbxserie";
            this.cbxserie.Size = new System.Drawing.Size(201, 21);
            this.cbxserie.TabIndex = 37;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Checked = true;
            this.rdbMasculino.Location = new System.Drawing.Point(390, 108);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 38;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemino
            // 
            this.rdbFemino.AutoSize = true;
            this.rdbFemino.Location = new System.Drawing.Point(495, 108);
            this.rdbFemino.Name = "rdbFemino";
            this.rdbFemino.Size = new System.Drawing.Size(67, 17);
            this.rdbFemino.TabIndex = 39;
            this.rdbFemino.TabStop = true;
            this.rdbFemino.Text = "Feminino";
            this.rdbFemino.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 42);
            this.button1.TabIndex = 40;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxcurso
            // 
            this.cbxcurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxcurso.FormattingEnabled = true;
            this.cbxcurso.Items.AddRange(new object[] {
            "1A2",
            "1B2",
            "1C2",
            "1D2",
            "2A2",
            "2B2",
            "2C2",
            "2D2",
            "3A2",
            "3B2",
            "3C2"});
            this.cbxcurso.Location = new System.Drawing.Point(219, 212);
            this.cbxcurso.Name = "cbxcurso";
            this.cbxcurso.Size = new System.Drawing.Size(201, 21);
            this.cbxcurso.TabIndex = 42;
            // 
            // lblcurso
            // 
            this.lblcurso.AutoSize = true;
            this.lblcurso.Location = new System.Drawing.Point(219, 193);
            this.lblcurso.Name = "lblcurso";
            this.lblcurso.Size = new System.Drawing.Size(34, 13);
            this.lblcurso.TabIndex = 41;
            this.lblcurso.Text = "Curso";
            // 
            // frmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 496);
            this.Controls.Add(this.cbxcurso);
            this.Controls.Add(this.lblcurso);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbFemino);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.cbxserie);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.lblDataDeNascimento);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dtpDtNascimento);
            this.Controls.Add(this.txtNomes);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.dtgAluno);
            this.Name = "frmAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aluno: Fellipe Barcelos Saraiva";
            this.Load += new System.EventHandler(this.frmAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.Label lblDataDeNascimento;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DateTimePicker dtpDtNascimento;
        private System.Windows.Forms.TextBox txtNomes;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.DataGridView dtgAluno;
        private System.Windows.Forms.ComboBox cbxserie;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFemino;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxcurso;
        private System.Windows.Forms.Label lblcurso;
    }
}