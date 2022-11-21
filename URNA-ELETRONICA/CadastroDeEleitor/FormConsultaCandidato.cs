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
    public partial class FormConsultaCandidato : Form
    {
        public FormConsultaCandidato()
        {
            InitializeComponent();
        }

        private void FormConsultaCandidato_Load(object sender, EventArgs e)
        {
            CandidatoBLL candidatoBLL = new CandidatoBLL();
           // bindingSourceCandidato.DataSource = candidatoBLL.BuscarTodos();//
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            CandidatoBLL candidatoBLL = new CandidatoBLL();
            if (radioButtonNumero.Checked)
            {
            bindingSourceCandidato.DataSource = candidatoBLL.BuscarPorNumero(Convert.ToInt32(textBoxNumero.Text));
            }
            else if (radioButtonTodos.Checked)
            {
                bindingSourceCandidato.DataSource = candidatoBLL.BuscarTodos();
            }
            else if(radioButtonNome.Checked)   
            {
                bindingSourceCandidato.DataSource = candidatoBLL.BuscarPorNome(textBoxNome.Text);
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastroCandidato frm = new FormCadastroCandidato())
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja excluir este candidato?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            CandidatoBLL candidatoBLL = new CandidatoBLL();

            candidatoBLL.Excluir(Convert.ToInt32(((DataRowView)bindingSourceCandidato.Current).Row["Id"]));

            MessageBox.Show("Registro excluido com sucesso");
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
