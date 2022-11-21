using BLL;
using MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UiTerminalWindows
{
    public partial class FormConsultaEleitor : Form
    {
        public FormConsultaEleitor()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormConsultaEleitor_Load(object sender, EventArgs e)
        {
            EleitorBLL eleitorBLL = new EleitorBLL();
            bindingSourceEleitor.DataSource = eleitorBLL.BuscarPorTitulo("");
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            EleitorBLL eleitorBLL = new EleitorBLL();
            if(radioButtonTitulo.Checked)
            {
            bindingSourceEleitor.DataSource = eleitorBLL.BuscarPorTitulo(textBoxBuscar.Text);
            }
            else if(radioButtonNome.Checked)
            {
             bindingSourceEleitor.DataSource = eleitorBLL.BuscarPorNome(textBoxBuscar.Text);
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastroEleitor frm = new FormCadastroEleitor(2))
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja excluir este candidato?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            EleitorBLL eleitorBLL = new EleitorBLL();

            eleitorBLL.Excluir(Convert.ToInt32(((DataRowView)bindingSourceEleitor.Current).Row["Id"]));

            MessageBox.Show("Registro excluido com sucesso");

        }

        private void labelAlterar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            using (FormCadastroEleitor frm = new FormCadastroEleitor(Convert.ToInt32(((DataRowView)bindingSourceEleitor.Current).Row["Id"])))
            {
                frm.ShowDialog();
            }
        }
    }
}
