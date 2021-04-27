namespace Turismo3B17
{
    partial class Igreja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Igreja));
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEstilo = new System.Windows.Forms.TextBox();
            this.dtpConstru = new System.Windows.Forms.DateTimePicker();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgIgreja = new System.Windows.Forms.DataGridView();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIgreja)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(115, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(440, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(115, 43);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(440, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(115, 82);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(440, 20);
            this.txtEndereco.TabIndex = 3;
            // 
            // txtEstilo
            // 
            this.txtEstilo.Location = new System.Drawing.Point(115, 163);
            this.txtEstilo.Name = "txtEstilo";
            this.txtEstilo.Size = new System.Drawing.Size(440, 20);
            this.txtEstilo.TabIndex = 4;
            // 
            // dtpConstru
            // 
            this.dtpConstru.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpConstru.Location = new System.Drawing.Point(244, 116);
            this.dtpConstru.Name = "dtpConstru";
            this.dtpConstru.Size = new System.Drawing.Size(311, 20);
            this.dtpConstru.TabIndex = 5;
            // 
            // cbxCidade
            // 
            this.cbxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Location = new System.Drawing.Point(115, 207);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(440, 21);
            this.cbxCidade.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "DESCRIÇÃO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "ENDEREÇO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "DATA DE CONSTRUÇÃO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "ESTILO";
            // 
            // dtgIgreja
            // 
            this.dtgIgreja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIgreja.Location = new System.Drawing.Point(12, 332);
            this.dtgIgreja.Name = "dtgIgreja";
            this.dtgIgreja.Size = new System.Drawing.Size(566, 150);
            this.dtgIgreja.TabIndex = 12;
            this.dtgIgreja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgIgreja_CellClick);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(12, 266);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(129, 44);
            this.btnGravar.TabIndex = 13;
            this.btnGravar.Text = "Gravar/Alterar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(165, 266);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(135, 44);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(322, 266);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(118, 44);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(470, 266);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 44);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "CIDADE";
            // 
            // Igreja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 494);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.dtgIgreja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCidade);
            this.Controls.Add(this.dtpConstru);
            this.Controls.Add(this.txtEstilo);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtID);
            this.Name = "Igreja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Igreja Fellipe Barcelos xD";
            this.Load += new System.EventHandler(this.Igreja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgIgreja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEstilo;
        private System.Windows.Forms.DateTimePicker dtpConstru;
        private System.Windows.Forms.ComboBox cbxCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgIgreja;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label6;
    }
}

