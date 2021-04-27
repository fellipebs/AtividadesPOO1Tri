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
    public partial class frmAluno : Form
    {
        public frmAluno()
        {
            InitializeComponent(); 
        }

        Conexao bd = new Conexao();

        public void CarregaCurso()
        {
            Conexao bd = new Conexao();
            cbxcurso.DataSource = bd.ExecutarConsulta("SELECT * FROM curso");
            cbxcurso.DisplayMember = "descricao";
            cbxcurso.ValueMember = "id";

        }
        private void limpar()
        {
            txtId.Text = ""; // ou usar o txtId.Clear();
            txtMatricula.Clear();
            txtNomes.Text = "";
            dtpDtNascimento.Value = DateTime.Now;
            rdbFemino.Checked = false;
            rdbMasculino.Checked = true;
            cbxserie.Text = "";
            cbxcurso.SelectedValue = 0;
            
        }

        private void listar()
        {
            Conexao bd = new Conexao();
            dtgAluno.DataSource = bd.ExecutarConsulta("SELECT * FROM aluno");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Conexao bd = new Conexao();

            char sexo;

            if (rdbFemino.Checked)
            {
                sexo = 'F';
            }
            else {
                 sexo = 'M';
            }

            
            string inserir = string.Format($@"INSERT INTO Aluno values(NULL,'{txtMatricula.Text}',
                                                                            '{txtNomes.Text}',
                                                                            '{cbxserie.Text}',
                                                                            '{sexo}',
                                                                            '{dtpDtNascimento.Value.ToString("yyyy/MM//dd")}',
                                                                             '{cbxcurso.SelectedValue}')");

            bd.ExecutarComando(inserir);
            MessageBox.Show("Dados Inseridos com sucesso");
            limpar();
            listar();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Conexao bd = new Conexao();

            char sexo = rdbFemino.Checked ? 'F' : rdbMasculino.Checked ? 'M' : ' ';

          //  if (rdbFemino.Checked)
           // {
             //   sexo = 'F';
           // }
            //else
            //{
             //   sexo = 'M';
           // }

            string atualizar = string.Format($@"UPDATE Aluno SET matricula = '{txtMatricula.Text}',
                                                                 nome = '{txtNomes.Text}',
                                                                 serieTurma = '{cbxserie.Text}',
                                                                 sexo = '{sexo}',
                                                                 dtNascimento = '{dtpDtNascimento.Value.ToString("yyyy/MM//dd")}',
                                                                 idCurso = '{cbxcurso.SelectedValue}'
                                                                 where Id = '{txtId.Text}'");
                                    
            bd.ExecutarComando(atualizar);
            MessageBox.Show("Dados Atualizados com sucesso");
            limpar();
            listar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Conexao bd = new Conexao();

            if(MessageBox.Show("Deseja realmente excluir o registro selecionado?","Confirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string deletar = string.Format($@"DELETE FROM Aluno where Id = '{txtId.Text}'");

                bd.ExecutarComando(deletar);
                MessageBox.Show("Dados Apagados com sucesso");
                limpar();
            }
            else{
                MessageBox.Show("OK!");
            }
            listar();
           
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Application.Exit();

       }

        private void frmAluno_Load(object sender, EventArgs e)
        {
            listar();
            CarregaCurso();
        }

        private void dtgAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgAluno.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMatricula.Text = dtgAluno.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNomes.Text = dtgAluno.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbxserie.Text = dtgAluno.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (dtgAluno.Rows[e.RowIndex].Cells[4].Value.ToString() == "F")
            {
                rdbFemino.Checked = true;
            }
            else
            {
                rdbMasculino.Checked = true;
            }
            dtpDtNascimento.Value = Convert.ToDateTime(dtgAluno.Rows[e.RowIndex].Cells[5].Value.ToString());
            cbxcurso.SelectedValue = dtgAluno.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
