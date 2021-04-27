namespace Turismo3B17
{
    partial class frmRestaurante
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
            this.dtgRestaurante = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbxHotel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRestaurante)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(119, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 66;
            this.label6.Text = "CIDADE";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(577, 303);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 44);
            this.btnSair.TabIndex = 65;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(429, 303);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(118, 44);
            this.btnExcluir.TabIndex = 64;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(272, 303);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(135, 44);
            this.btnLimpar.TabIndex = 63;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(119, 303);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(129, 44);
            this.btnGravar.TabIndex = 62;
            this.btnGravar.Text = "Gravar/Alterar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // dtgRestaurante
            // 
            this.dtgRestaurante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRestaurante.Location = new System.Drawing.Point(119, 369);
            this.dtgRestaurante.Name = "dtgRestaurante";
            this.dtgRestaurante.Size = new System.Drawing.Size(566, 150);
            this.dtgRestaurante.TabIndex = 61;
            this.dtgRestaurante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRestaurante_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(125, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 60;
            this.label5.Text = "Hotel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(119, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "ENDEREÇO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(119, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Nome do restaurante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(119, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "ID";
            // 
            // cbxCidade
            // 
            this.cbxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Location = new System.Drawing.Point(222, 179);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(440, 21);
            this.cbxCidade.TabIndex = 56;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(222, 119);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(440, 20);
            this.txtEndereco.TabIndex = 54;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(278, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(384, 20);
            this.txtNome.TabIndex = 53;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(222, 43);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(440, 20);
            this.txtID.TabIndex = 52;
            // 
            // cbxHotel
            // 
            this.cbxHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHotel.FormattingEnabled = true;
            this.cbxHotel.Location = new System.Drawing.Point(222, 235);
            this.cbxHotel.Name = "cbxHotel";
            this.cbxHotel.Size = new System.Drawing.Size(440, 21);
            this.cbxHotel.TabIndex = 67;
            // 
            // frmRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.cbxHotel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.dtgRestaurante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCidade);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Name = "frmRestaurante";
            this.Text = "frmRestaurante";
            this.Load += new System.EventHandler(this.frmRestaurante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRestaurante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DataGridView dtgRestaurante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCidade;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cbxHotel;
    }
}