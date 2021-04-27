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
    public partial class frmHotel : Form
    {
        public frmHotel()
        {
            InitializeComponent();
        }

        private HotelBLL objHotelBLL = new HotelBLL();
        private CidadeBLL objtCidadeBLL = new CidadeBLL();

        private void CarregarGridHotel()
        {
            dtgHotel.DataSource = objHotelBLL.ListarHotel();
        }

        private void CarregarCidades()
        {
            cbxCidade.DataSource = objtCidadeBLL.ListarCidades();
            cbxCidade.DisplayMember = "nomeCidade";
            cbxCidade.ValueMember = "idCidade";
        }

        private void frmHotel_Load(object sender, EventArgs e)
        {
            CarregarCidades();
            CarregarGridHotel();
        }

        private void Limpar()
        {
            txtCategoria.Text = "";
            txtEndereco.Clear();
            txtID.Clear();
            txtNome.Text = "";
            cbxCidade.SelectedValue = 0;
           
        }

 
       
      
        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir essa bagaça?", "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objHotelBLL.Id = Convert.ToInt32(txtID.Text);
                objHotelBLL.ExcluirHotel();
                CarregarGridHotel();

            }
            Limpar();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
                objHotelBLL.Nome = txtNome.Text;
                objHotelBLL.Endereco = txtEndereco.Text;
                objHotelBLL.Categoria = txtCategoria.Text;
                objHotelBLL.IdCidade = Convert.ToInt32(cbxCidade.SelectedValue);

                if (txtID.Text == String.Empty)
                {
                    objHotelBLL.InserirHotel();
                }
                else
                {
                    objHotelBLL.Id = Convert.ToInt32(txtID.Text);
                    objHotelBLL.AlterarHotel();
                }
                CarregarGridHotel();
                Limpar();
            }

        private void dtgHotel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtgHotel.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgHotel.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEndereco.Text = dtgHotel.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCategoria.Text = dtgHotel.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbxCidade.SelectedValue = dtgHotel.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }

      
    }

