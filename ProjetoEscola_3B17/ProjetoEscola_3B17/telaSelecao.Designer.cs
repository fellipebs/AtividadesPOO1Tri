namespace ProjetoEscola_3B17
{
    partial class telaSelecao
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
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAluno
            // 
            this.btnAluno.Location = new System.Drawing.Point(12, 85);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(119, 67);
            this.btnAluno.TabIndex = 0;
            this.btnAluno.Text = "Aluno";
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // btnProfessor
            // 
            this.btnProfessor.Location = new System.Drawing.Point(171, 85);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(119, 67);
            this.btnProfessor.TabIndex = 1;
            this.btnProfessor.Text = "Professor";
            this.btnProfessor.UseVisualStyleBackColor = true;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // telaSelecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 236);
            this.Controls.Add(this.btnProfessor);
            this.Controls.Add(this.btnAluno);
            this.Name = "telaSelecao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaSelecao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnProfessor;
    }
}