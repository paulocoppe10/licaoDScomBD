using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace licaods
{
    public partial class frmPesquisaCliente : Form
    {
        private int codigo;
        public frmPesquisaCliente()
        {
            InitializeComponent();
        }
        public int getCodigo()
        {
            return codigo;
        }
 
        private void frmPesquisaCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroDataSet.tbcliente' table. You can move, or remove it, as needed.
            this.tbclienteTableAdapter.Fill(this.cadastroDataSet.tbcliente);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbclienteTableAdapter.Fill(this.cadastroDataSet.tbcliente);
            }
            else
            {
                this.tbclienteTableAdapter.FillByNome(this.cadastroDataSet.tbcliente, "%" + txtNome.Text + "%");
            }
        }

        private void tbclienteDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tbclienteDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }
    }
}
