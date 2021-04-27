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

namespace Prova1_3B_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         private OrdemServicoBLL objOrdemServicoBLL = new OrdemServicoBLL();

        private void CarregarGridOrdemServico()
        {
            dtgServicos.DataSource = objOrdemServicoBLL.ListarOrdemServico();
        }

        private void Limpar()
        {
            txtId.Text = "";
            txtDescricao.Text = "";
            txtDepartamento.Text = "";
            txtNomeUsu.Clear();
            dtpDataChamado.Value = DateTime.Now;
            txtTecnicoResp.Clear();
            cbxOrdemSitu.SelectedValue = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarGridOrdemServico();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objOrdemServicoBLL.Id = Convert.ToInt32(txtId.Text);
                objOrdemServicoBLL.ExcluirOrdemServico();
                CarregarGridOrdemServico();

            }
            Limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            objOrdemServicoBLL.Descricao = txtDescricao.Text;
            objOrdemServicoBLL.Departamento = txtDepartamento.Text;
            objOrdemServicoBLL.NomeUsuario = txtNomeUsu.Text;
            objOrdemServicoBLL.Data_chamado = dtpDataChamado.Value;
            objOrdemServicoBLL.TecnicoResponsavel = txtTecnicoResp.Text;
            objOrdemServicoBLL.SituacaoOrdem = cbxOrdemSitu.Text;

            if (txtId.Text == String.Empty)
            {
                objOrdemServicoBLL.InserirOrdemServico();
            }
            else
            {
                objOrdemServicoBLL.Id = Convert.ToInt32(txtId.Text);
                objOrdemServicoBLL.AlterarOrdemServico();
            }
            CarregarGridOrdemServico();
            Limpar();

        }

        private void dtgServicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgServicos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescricao.Text = dtgServicos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDepartamento.Text = dtgServicos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNomeUsu.Text = dtgServicos.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtpDataChamado.Value = Convert.ToDateTime(dtgServicos.Rows[e.RowIndex].Cells[4].Value.ToString());
            txtTecnicoResp.Text = dtgServicos.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbxOrdemSitu.Text = dtgServicos.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
