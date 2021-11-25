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
    public partial class frmPesquisaFornecedor : Form
    {
        private int codigo;
        public frmPesquisaFornecedor()
        {
            InitializeComponent();
        }
        public int getCodigo()
        {
            return codigo;
        }


        private void frmPesquisaFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroDataSet.tbfornecedor' table. You can move, or remove it, as needed.
            this.tbfornecedorTableAdapter.Fill(this.cadastroDataSet.tbfornecedor);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbfornecedorTableAdapter.Fill(this.cadastroDataSet.tbfornecedor);
            }
            else
            {
                this.tbfornecedorTableAdapter.FillByNome(this.cadastroDataSet.tbfornecedor, "%" + txtNome.Text + "%");
            }
        }

        private void tbfornecedorDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tbfornecedorDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }
    }
}
