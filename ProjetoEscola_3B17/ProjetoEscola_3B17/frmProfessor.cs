using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace ProjetoEscola_3B17
{
    public partial class frmProfessor : Form
    {
        public frmProfessor()
        {
            InitializeComponent();
        }

        public void CarregaEscolaridade()
        {
            Conexao bd = new Conexao();
            cbxescolaridade.DataSource = bd.ExecutarConsulta("SELECT * FROM escolaridade");
            cbxescolaridade.DisplayMember = "descricao";
            cbxescolaridade.ValueMember = "id";

        }

        private void limpar()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtCargaHoraria.Text = "";
            txtSalario.Text = "";
            cbxdisciplina.Text = "";
            dtpDtAdmissao.Value = DateTime.Now;
            cbxescolaridade.SelectedValue = 0;
        }

        private void listar()
        {
            Conexao bd = new Conexao();
            dtgProfessor.DataSource = bd.ExecutarConsulta("SELECT * FROM professor");
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Conexao bd = new Conexao();

           
 

            string inserir = string.Format($@"INSERT INTO professor values(NULL,'{txtNome.Text}',
                                                                                '{cbxdisciplina.Text}',
                                                                                '{dtpDtAdmissao.Value.ToString("yyyy/MM//dd")}',
                                                                                '{txtCargaHoraria.Text}',
                                                                                '{txtSalario.Text}',
                                                                                '{cbxescolaridade.SelectedValue}')");

            bd.ExecutarComando(inserir);
            MessageBox.Show("Dados Inseridos com sucesso");
            limpar();
            listar();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Conexao bd = new Conexao();
            string atualizar = string.Format($@"UPDATE  professor SET nome = '{txtNome.Text}',
                                                                      disciplina = '{cbxdisciplina.Text}',
                                                                      dtAdmissao = '{dtpDtAdmissao.Value.ToString("yyyy/MM/dd")}',
                                                                      cargaHoraria = '{txtCargaHoraria.Text}',
                                                                      salario = '{txtSalario.Text}',
                                                                      idEscolaridade = '{cbxescolaridade.SelectedValue}' 
                                                                      where id = '{txtId.Text}'");

            bd.ExecutarComando(atualizar);
            MessageBox.Show("Dados Atualizados com sucesso");
            limpar();
            listar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Conexao bd = new Conexao();

            if (MessageBox.Show("Deseja realmente excluir o registro selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string deletar = string.Format($@"DELETE FROM professor where Id = '{txtId.Text}'");

                bd.ExecutarComando(deletar);
                MessageBox.Show("Dados Apagados com sucesso");
                limpar();
            }
            else
            {
                MessageBox.Show("OK!");
            }
            listar();

        }

        private void frmProfessor_Load(object sender, EventArgs e)
        {
            CarregaEscolaridade();
            listar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtgProfessor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgProfessor.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgProfessor.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbxdisciplina.Text = dtgProfessor.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpDtAdmissao.Value = Convert.ToDateTime(dtgProfessor.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtCargaHoraria.Text = dtgProfessor.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSalario.Text = dtgProfessor.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbxescolaridade.SelectedValue = dtgProfessor.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
