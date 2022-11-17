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
    public partial class FormCadastroEleicao : Form
    {
        public FormCadastroEleicao()
        {
            InitializeComponent();
        }

        private void FormCadastroEleicao_Load(object sender, EventArgs e)
        {
            Eleicao eleicao = new Eleicao();
            bindingSourceEleicao.DataSource = eleicao;
            bindingSourceEleicao.AddNew();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            bindingSourceEleicao.EndEdit();
            EleicaoBLL eleicaoBLL = new EleicaoBLL();
            eleicaoBLL.Inserir((Eleicao)bindingSourceEleicao.Current);
            MessageBox.Show("Ano e Turno salvos com sucesso");
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelado o cadastro de Eleicao");
            Close();
        }

    }
}
