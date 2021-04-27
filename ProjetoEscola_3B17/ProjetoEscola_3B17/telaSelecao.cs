using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEscola_3B17
{
    public partial class telaSelecao : Form
    {
        public telaSelecao()
        {
            InitializeComponent();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            
            frmAluno novaform = new frmAluno();
            novaform.Show();
          
        }
       

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            
            frmProfessor novaform = new frmProfessor();
            novaform.Show();
        
        }
    }

}
