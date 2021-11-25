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
    public partial class frmPesquisaUsuario : Form
    {
        private int codigo;
        public frmPesquisaUsuario()
        {
            InitializeComponent();
        }
        public int getCodigo()
        {
            return codigo;
        }

        private void frmPesquisaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroDataSet.tbusuario' table. You can move, or remove it, as needed.
            this.tbusuarioTableAdapter.Fill(this.cadastroDataSet.tbusuario);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text =="")
            {
                this.tbusuarioTableAdapter.Fill(this.cadastroDataSet.tbusuario);
            }
            else
            {
                this.tbusuarioTableAdapter.FillByNome(this.cadastroDataSet.tbusuario,"%"+txtNome.Text+"%");
            }

        }

        private void tbusuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tbusuarioDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }
    }
}
