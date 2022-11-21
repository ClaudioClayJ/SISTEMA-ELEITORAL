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
    public partial class FormConsultaEleicao : Form
    {
        public FormConsultaEleicao()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            EleicaoBLL eleicaoBLL = new EleicaoBLL();
            if (radioButtonAno.Checked)
            {
                bindingSourceEleicao.DataSource = eleicaoBLL.BuscarPorAno(Convert.ToInt32(textBoxAno.Text));
            }
            else if (radioButtonTurno.Checked)
            {
                bindingSourceEleicao.DataSource = eleicaoBLL.BuscarPorTurno(Convert.ToInt32(textBoxTurno.Text));
            }
        }

        private void FormConsultaEleicao_Load(object sender, EventArgs e)
        {
            EleicaoBLL eleicaoBLL = new EleicaoBLL();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastroEleicao frm = new FormCadastroEleicao())
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja excluir esta eleiçao?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            EleicaoBLL eleicaoBLL = new EleicaoBLL();

            eleicaoBLL.Excluir(Convert.ToInt32(((DataRowView)bindingSourceEleicao.Current).Row["Id"]));

            MessageBox.Show("Registro excluido com sucesso");
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            using (FormCadastroEleicao frm = new FormCadastroEleicao(Convert.ToInt32(((DataRowView)bindingSourceEleicao.Current).Row["Id"])))
            {
                frm.ShowDialog();
            }
        }
    }
}
