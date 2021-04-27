namespace Prova1_3B_17
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataChamado = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNomeUsu = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtTecnicoResp = new System.Windows.Forms.TextBox();
            this.dtgServicos = new System.Windows.Forms.DataGridView();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.cbxOrdemSitu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome do usuário";
            // 
            // dtpDataChamado
            // 
            this.dtpDataChamado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataChamado.Location = new System.Drawing.Point(354, 152);
            this.dtpDataChamado.Name = "dtpDataChamado";
            this.dtpDataChamado.Size = new System.Drawing.Size(162, 20);
            this.dtpDataChamado.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Data do chamado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Técnico Responsável";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Situação da ordem";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(354, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(162, 20);
            this.txtId.TabIndex = 8;
            // 
            // txtNomeUsu
            // 
            this.txtNomeUsu.Location = new System.Drawing.Point(354, 126);
            this.txtNomeUsu.Name = "txtNomeUsu";
            this.txtNomeUsu.Size = new System.Drawing.Size(162, 20);
            this.txtNomeUsu.TabIndex = 9;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(354, 89);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(162, 20);
            this.txtDepartamento.TabIndex = 10;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(354, 58);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(162, 20);
            this.txtDescricao.TabIndex = 11;
            // 
            // txtTecnicoResp
            // 
            this.txtTecnicoResp.Location = new System.Drawing.Point(354, 192);
            this.txtTecnicoResp.Name = "txtTecnicoResp";
            this.txtTecnicoResp.Size = new System.Drawing.Size(162, 20);
            this.txtTecnicoResp.TabIndex = 12;
            // 
            // dtgServicos
            // 
            this.dtgServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgServicos.Location = new System.Drawing.Point(27, 314);
            this.dtgServicos.Name = "dtgServicos";
            this.dtgServicos.Size = new System.Drawing.Size(645, 150);
            this.dtgServicos.TabIndex = 14;
            this.dtgServicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgServicos_CellClick);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(134, 272);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(95, 23);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "Gravar/Alterar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(263, 272);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(373, 272);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(486, 272);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // cbxOrdemSitu
            // 
            this.cbxOrdemSitu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrdemSitu.FormattingEnabled = true;
            this.cbxOrdemSitu.Items.AddRange(new object[] {
            "Em Aberto",
            "Encerrada",
            "Em Andamento",
            "Pendente",
            "Cancelada",
            "Seviço Realizado"});
            this.cbxOrdemSitu.Location = new System.Drawing.Point(354, 231);
            this.cbxOrdemSitu.Name = "cbxOrdemSitu";
            this.cbxOrdemSitu.Size = new System.Drawing.Size(162, 21);
            this.cbxOrdemSitu.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 485);
            this.Controls.Add(this.cbxOrdemSitu);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.dtgServicos);
            this.Controls.Add(this.txtTecnicoResp);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtNomeUsu);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDataChamado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgServicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataChamado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNomeUsu;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtTecnicoResp;
        private System.Windows.Forms.DataGridView dtgServicos;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cbxOrdemSitu;
    }
}

