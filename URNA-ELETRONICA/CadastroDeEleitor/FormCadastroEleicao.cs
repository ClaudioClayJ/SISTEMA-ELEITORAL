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
        private int id;
        public FormCadastroEleicao(int id = 0)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FormCadastroEleicao_Load(object sender, EventArgs e)
        {
            Eleicao eleicao = new Eleicao();
            bindingSourceEleicao.DataSource = eleicao;
            bindingSourceEleicao.AddNew();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            EleicaoBLL eleicaoBLL = new EleicaoBLL();
            if (id == 0)
            {
                bindingSourceEleicao.EndEdit();
                eleicaoBLL.Inserir((Eleicao)bindingSourceEleicao.Current);
                MessageBox.Show("Eleicao salvo com sucesso");
            }
            else
            {
                Eleicao eleicao = new Eleicao();
                eleicao.Id = id;
                eleicao.Ano = Convert.ToInt32(textBoxAno.Text);
                eleicao.Turno = Convert.ToInt32(textBoxTurno.Text);
                eleicaoBLL.Alterar(eleicao);
                MessageBox.Show("Eleição alterado com sucesso!");
            }
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelado o cadastro de Eleicao");
            Close();
        }

    }
}
