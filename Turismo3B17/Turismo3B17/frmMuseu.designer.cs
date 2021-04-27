namespace Turismo3B17
{
    partial class frmMuseu
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.dtgMuseu = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.dtpConstru = new System.Windows.Forms.DateTimePicker();
            this.txtn_salas = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMuseu)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(42, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "CIDADE";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(500, 287);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 44);
            this.btnSair.TabIndex = 33;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(352, 287);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(118, 44);
            this.btnExcluir.TabIndex = 32;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(195, 287);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(135, 44);
            this.btnLimpar.TabIndex = 31;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(42, 287);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(129, 44);
            this.btnGravar.TabIndex = 30;
            this.btnGravar.Text = "Gravar/Alterar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // dtgMuseu
            // 
            this.dtgMuseu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMuseu.Location = new System.Drawing.Point(42, 353);
            this.dtgMuseu.Name = "dtgMuseu";
            this.dtgMuseu.Size = new System.Drawing.Size(566, 150);
            this.dtgMuseu.TabIndex = 29;

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(39, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Número de salas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(42, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "DATA DE CONSTRUÇÃO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(42, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "ENDEREÇO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(42, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "DESCRIÇÃO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID";
            // 
            // cbxCidade
            // 
            this.cbxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Location = new System.Drawing.Point(145, 228);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(440, 21);
            this.cbxCidade.TabIndex = 23;
            // 
            // dtpConstru
            // 
            this.dtpConstru.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpConstru.Location = new System.Drawing.Point(274, 137);
            this.dtpConstru.Name = "dtpConstru";
            this.dtpConstru.Size = new System.Drawing.Size(311, 20);
            this.dtpConstru.TabIndex = 22;
            // 
            // txtn_salas
            // 
            this.txtn_salas.Location = new System.Drawing.Point(174, 184);
            this.txtn_salas.Name = "txtn_salas";
            this.txtn_salas.Size = new System.Drawing.Size(411, 20);
            this.txtn_salas.TabIndex = 21;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(145, 103);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(440, 20);
            this.txtEndereco.TabIndex = 20;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(145, 64);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(440, 20);
            this.txtDescricao.TabIndex = 19;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(145, 27);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(440, 20);
            this.txtID.TabIndex = 18;
            // 
            // frmMuseu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 536);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.dtgMuseu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCidade);
            this.Controls.Add(this.dtpConstru);
            this.Controls.Add(this.txtn_salas);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtID);
            this.Name = "frmMuseu";
            this.Text = "frmMuseu";
            this.Load += new System.EventHandler(this.frmMuseu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMuseu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DataGridView dtgMuseu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCidade;
        private System.Windows.Forms.DateTimePicker dtpConstru;
        private System.Windows.Forms.TextBox txtn_salas;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtID;
    }
}