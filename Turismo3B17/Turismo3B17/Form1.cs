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

//nao coloque using DAL
namespace Turismo3B17
{
    public partial class Igreja : Form
    {
        public Igreja()
        {
            InitializeComponent();
        }

        private IgrejaBLL objIgrejaBLL = new IgrejaBLL();
        private CidadeBLL objtCidadeBLL = new CidadeBLL();

        private void CarregarGridIgrejas()
        {
            dtgIgreja.DataSource = objIgrejaBLL.ListarIgrejas();
        }

        private void CarregarCidades()
        {
            cbxCidade.DataSource = objtCidadeBLL.ListarCidades();
            cbxCidade.DisplayMember = "nomeCidade";
            cbxCidade.ValueMember = "idCidade";
        }

        private void Igreja_Load(object sender, EventArgs e)
        {
            CarregarCidades();
            CarregarGridIgrejas();
        }

        private void Limpar()
        {
            txtDescricao.Text = "";
            txtEndereco.Clear();
            txtID.Clear();
            dtpConstru.Value = DateTime.Now;
            cbxCidade.SelectedValue = 0;
            txtEstilo.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void dtgIgreja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtgIgreja.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescricao.Text = dtgIgreja.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEndereco.Text = dtgIgreja.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpConstru.Value = Convert.ToDateTime(dtgIgreja.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtEstilo.Text = dtgIgreja.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbxCidade.SelectedValue = dtgIgreja.Rows[e.RowIndex].Cells[5].Value.ToString();
           
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                // we will fill the variables using Set by Encapsulamento
                objIgrejaBLL.Descricao = txtDescricao.Text;
                objIgrejaBLL.Endereco = txtEndereco.Text;
                objIgrejaBLL.Data_construcao = dtpConstru.Value;
                objIgrejaBLL.Estilo = txtEstilo.Text;
                objIgrejaBLL.IdCidade = Convert.ToInt32(cbxCidade.SelectedValue);

                if (txtID.Text == String.Empty)
                {
                    objIgrejaBLL.InserirIgreja();
                }
                else
                {
                    objIgrejaBLL.Id = Convert.ToInt32(txtID.Text);
                    objIgrejaBLL.AlterarIgreja();
                }
                CarregarGridIgrejas();
                Limpar();
            }
           
            catch(Exception ex){

                MessageBox.Show(ex.Message);
            }
         
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir essa bagaça?", "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objIgrejaBLL.Id = Convert.ToInt32(txtID.Text);
                    objIgrejaBLL.ExcluirIgreja();
                    CarregarGridIgrejas();
                }
                Limpar();
            }
            catch (FormatException)
            {
                MessageBox.Show("O id deve ser preenchido com um valor numérico.");
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);

            }
            
        }
    }
}
