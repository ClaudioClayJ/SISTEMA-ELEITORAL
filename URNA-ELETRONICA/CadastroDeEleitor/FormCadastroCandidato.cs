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
    public partial class FormCadastroCandidato : Form
    {
        private int id;
        public FormCadastroCandidato()
        {
            InitializeComponent();
            id = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LabelNome_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvarCandidato_Click(object sender, EventArgs e)
        {
            bindingSourceCandidato.EndEdit();
            CandidatoBLL candidatoBLL = new CandidatoBLL();
            candidatoBLL.Inserir((Candidato)bindingSourceCandidato.Current);
            MessageBox.Show("Candidato salvo com sucesso");

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelar cadastro de Candidato");
            Close();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FormCadastroCandidato_Load(object sender, EventArgs e)
        {
            Candidato candidato = new Candidato();
            bindingSourceCandidato.DataSource = candidato;
            bindingSourceCandidato.AddNew();
        }
    }
}
