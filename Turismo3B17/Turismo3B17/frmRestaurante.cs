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
    public partial class frmRestaurante : Form
    {
        public frmRestaurante()
        {
            InitializeComponent();
        }
        private HotelBLL objHotelBLL = new HotelBLL();
        private CidadeBLL objtCidadeBLL = new CidadeBLL();
        private RestauranteBLL objtRestauranteBLL = new RestauranteBLL();

        private void CarregarGridRestaurante()
        {
            dtgRestaurante.DataSource = objtRestauranteBLL.ListarRestaurante();
        }
        private void CarregarCidades()
        {
            cbxCidade.DataSource = objtCidadeBLL.ListarCidades();
            cbxCidade.DisplayMember = "nomeCidade";
            cbxCidade.ValueMember = "idCidade";
        }
        private void CarregarHoteis()
        {
            cbxHotel.DataSource = objHotelBLL.ListarHotel();
            cbxHotel.DisplayMember = "nomeHotel";
            cbxHotel.ValueMember = "idHotel";
        }

        private void Limpar()
        {
            txtEndereco.Text = "";
            txtID.Clear();
            txtNome.Clear();
            cbxCidade.SelectedValue = 0;
            cbxHotel.SelectedValue = 0;

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            objtRestauranteBLL.Nome = txtNome.Text;
            objtRestauranteBLL.Endereco = txtEndereco.Text;
            objtRestauranteBLL.IdCidade = Convert.ToInt32(cbxCidade.SelectedValue);
            objtRestauranteBLL.IdHotel = Convert.ToInt32(cbxHotel.SelectedValue);

            if (txtID.Text == String.Empty)
            {
                objtRestauranteBLL.InserirRestaurante();
            }
            else
            {
                objtRestauranteBLL.Id = Convert.ToInt32(txtID.Text);
                objtRestauranteBLL.AlterarRestaurante();
            }
            CarregarGridRestaurante();
            Limpar();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir essa bagaça?", "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objtRestauranteBLL.Id = Convert.ToInt32(txtID.Text);
                objtRestauranteBLL.ExcluirRestaurante();
                CarregarGridRestaurante();

            }
            Limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtgRestaurante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtgRestaurante.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgRestaurante.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEndereco.Text = dtgRestaurante.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbxCidade.SelectedValue = dtgRestaurante.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbxHotel.SelectedValue = dtgRestaurante.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void frmRestaurante_Load(object sender, EventArgs e)
        {
            CarregarCidades();
            CarregarGridRestaurante();
            CarregarHoteis();
        }
    }
}
