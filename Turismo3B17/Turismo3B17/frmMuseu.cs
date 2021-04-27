using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Turismo3B17
{
    public partial class frmMuseu : Form
    {
        public frmMuseu()
        {
            InitializeComponent();
        }

        private MuseuBLL objMuseuBLL = new MuseuBLL();
        private CidadeBLL objtCidadeBLL = new CidadeBLL();

        private void CarregarGridMuseus()
        {
            dtgMuseu.DataSource = objMuseuBLL.ListarMuseus();
        }

        private void CarregarCidades()
        {
            cbxCidade.DataSource = objtCidadeBLL.ListarCidades();
            cbxCidade.DisplayMember = "nomeCidade";
            cbxCidade.ValueMember = "idCidade";
        }

        private void frmMuseu_Load(object sender, EventArgs e)
        {
            CarregarCidades();
            CarregarGridMuseus();
        }

        private void Limpar()
        {
            txtDescricao.Text = "";
            txtEndereco.Clear();
            txtID.Clear();
            dtpConstru.Value = DateTime.Now;
            cbxCidade.SelectedValue = 0;
            txtn_salas.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir essa bagaça?", "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objMuseuBLL.Id = Convert.ToInt32(txtID.Text);
                objMuseuBLL.ExcluirMuseu();
                CarregarGridMuseus();

            }
            Limpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try {
                objMuseuBLL.Descricao = txtDescricao.Text;
                objMuseuBLL.Endereco = txtEndereco.Text;
                objMuseuBLL.Data_fundacao = dtpConstru.Value;
                objMuseuBLL.N_salas = Convert.ToInt32(txtn_salas.Text);
                objMuseuBLL.IdCidade = Convert.ToInt32(cbxCidade.SelectedValue);

                if (txtID.Text == String.Empty)
                {
                    objMuseuBLL.InserirMuseu();
                }
                else
                {
                    objMuseuBLL.Id = Convert.ToInt32(txtID.Text);
                    objMuseuBLL.AlterarMuseu();
                }
                CarregarGridMuseus();
                Limpar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

      

        private void dtgMuseu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dtgMuseu.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDescricao.Text = dtgMuseu.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtEndereco.Text = dtgMuseu.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpConstru.Value = Convert.ToDateTime(dtgMuseu.Rows[e.RowIndex].Cells[3].Value.ToString());
                txtn_salas.Text = dtgMuseu.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbxCidade.SelectedValue = dtgMuseu.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
    }
}
