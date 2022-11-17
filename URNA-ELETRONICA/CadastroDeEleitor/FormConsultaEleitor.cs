using BLL;
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
            EleitorBLL eleitor = new EleitorBLL();
            bindingSourceEleitor.DataSource = eleitor.BuscarPorTitulo("");
        }
    }
}
