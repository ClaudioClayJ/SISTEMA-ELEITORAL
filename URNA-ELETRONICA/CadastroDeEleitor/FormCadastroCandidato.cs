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
        public FormCadastroCandidato(int _id = 0)
        {
            InitializeComponent();
            id = _id; 
        }


        private void buttonSalvarCandidato_Click(object sender, EventArgs e)
        {
            CandidatoBLL candidatoBLL = new CandidatoBLL();
            if (id == 0)
            {
                bindingSourceCandidato.EndEdit();
                candidatoBLL.Inserir((Candidato)bindingSourceCandidato.Current);
                MessageBox.Show("Candidato salvo com sucesso");
            }
            else
            {
                Candidato candidato = new Candidato();
                candidato.Id = id;
                candidato.Nome = textBoxNome.Text;
                candidato.Numero = Convert.ToInt32(textBoxNumero.Text);
                candidatoBLL.Alterar(candidato);
                MessageBox.Show("Candidato alterado com sucesso!");
            }
            Close();

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
            if (id == 0)
            {
                Candidato candidato = new Candidato();
                bindingSourceCandidato.DataSource = candidato;
                bindingSourceCandidato.AddNew();
            }
            else
            {
                CandidatoBLL candidatoBLL = new CandidatoBLL();
                bindingSourceCandidato.DataSource = candidatoBLL.BuscarPorId(id);
            }

        }
    }
}
