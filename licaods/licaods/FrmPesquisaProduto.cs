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
    public partial class FrmPesquisaProduto : Form
    {
        private int codigo;
        public FrmPesquisaProduto()
        {
            InitializeComponent();
        }
        public int getCodigo()
        {
            return codigo;
        }



        private void FrmPesquisaProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroDataSet.tbproduto' table. You can move, or remove it, as needed.
            this.tbprodutoTableAdapter.Fill(this.cadastroDataSet.tbproduto);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbprodutoTableAdapter.Fill(this.cadastroDataSet.tbproduto);
            }
            else
            {
                this.tbprodutoTableAdapter.FillByNome(this.cadastroDataSet.tbproduto, "%" + txtNome.Text + "%");
            }
        }

        private void tbprodutoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tbprodutoDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }
    }
}
