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
    public partial class FormCadastroEleitor : Form
    {
        private int id;
        public FormCadastroEleitor(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            EleitorBLL eleitorBLL = new EleitorBLL();
            if(id == 0)
            {
            bindingSourceEleitor.EndEdit();
            eleitorBLL.Inserir((Eleitor)bindingSourceEleitor.Current);
            MessageBox.Show("Eleitor salvo com sucesso");
            }
            else
            {
                Eleitor eleitor = new Eleitor();
                eleitor.Id = id;
                eleitor.Nome = textBoxNome.Text;
                eleitor.TituloEleitor = textBoxTitulo.Text;
                eleitor.Votou = checkBoxVotou.Checked;
                eleitorBLL.Alterar(eleitor);
                MessageBox.Show("Eleitor alterado com sucesso!");
            }
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelar cadastro de Elelitor");
            Close();
        }

        private void FormCadastroEleitor_Load(object sender, EventArgs e)
        {
            if (id == 0)
            {
            Eleitor eleitor = new Eleitor();
                bindingSourceEleitor.DataSource = eleitor;
                bindingSourceEleitor.AddNew();
            }
            else
            {
                EleitorBLL eleitorBLL = new EleitorBLL();
                bindingSourceEleitor.DataSource = eleitorBLL.BuscarPorId(id);
            }
            
        }

        
    }
}
