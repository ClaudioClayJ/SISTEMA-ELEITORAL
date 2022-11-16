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
        public FormCadastroEleitor()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            bindingSourceEleitor.EndEdit();
            EleitorBLL eleitorBLL = new EleitorBLL();
            eleitorBLL.Inserir((Eleitor)bindingSourceEleitor.Current);
            MessageBox.Show("Eleitor salvo com sucesso");
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
            Eleitor eleitor = new Eleitor();
            bindingSourceEleitor.DataSource = eleitor;
            bindingSourceEleitor.AddNew();
        }
    }
}
