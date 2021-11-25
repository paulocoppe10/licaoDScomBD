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
    public partial class frmproduto : Form
    {
        private void Habilita()
        {
            cd_produtoTextBox.Enabled = false;
            nm_produtoTextBox.Enabled = true;
            nm_categoriaTextBox.Enabled = true;
            qt_estoqueTextBox.Enabled = true;
            vl_custoTextBox.Enabled = true;
            vl_vendaTextBox.Enabled = true;
            btnsalvar.Enabled = true;
            btncancelar.Enabled = true;
            btnanterior.Enabled = false;
            btnproximo.Enabled = false;
            btnnovo.Enabled = false;
            btnalterar.Enabled = false;
            btnexcluir.Enabled = false;
            btnpesquisar.Enabled = false;
            btnimprimir.Enabled = false;
            btnsair.Enabled = false;
        }

        private void Desabilita()
        {
            cd_produtoTextBox.Enabled = false;
            nm_produtoTextBox.Enabled = false;
            nm_categoriaTextBox.Enabled = false;
            qt_estoqueTextBox.Enabled = false;
            vl_custoTextBox.Enabled = false;
            vl_vendaTextBox.Enabled = false;

            btnsalvar.Enabled = false;
            btncancelar.Enabled = false;
            btnanterior.Enabled = true;
            btnproximo.Enabled = true;
            btnnovo.Enabled = true;
            btnalterar.Enabled = true;
            btnexcluir.Enabled = true;
            btnpesquisar.Enabled = true;
            btnimprimir.Enabled = true;
            btnsair.Enabled = true;
        }
        public frmproduto()
        {
            InitializeComponent();
        }

        private void frmproduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroDataSet.tbproduto' table. You can move, or remove it, as needed.
            this.tbprodutoTableAdapter.Fill(this.cadastroDataSet.tbproduto);
            Desabilita();

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            tbprodutoBindingSource.MovePrevious();
        }

        private void btnproximo_Click(object sender, EventArgs e)
        {
            tbprodutoBindingSource.MoveNext();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            tbprodutoBindingSource.AddNew();
            Habilita();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            tbprodutoBindingSource.RemoveCurrent();
            tbprodutoTableAdapter.Update(cadastroDataSet.tbproduto);
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbprodutoBindingSource.EndEdit();
            tbprodutoTableAdapter.Update(cadastroDataSet.tbproduto);
            Desabilita();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            tbprodutoBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objimpressao = e.Graphics;
            strDados = "FICHA FORNECEDOR" + (char)10 + (char)10;
            strDados += "CODIGO: " + cd_produtoTextBox.Text + (char)10 + (char)10;
            strDados += "NOME PRODUTO : " + nm_produtoTextBox.Text + (char)10 + (char)10;
            strDados += "CATEGORIA: " + nm_categoriaTextBox.Text + (char)10 + (char)10;
            strDados += "quantidade " + qt_estoqueTextBox.Text + (char)10 + (char)10;
            strDados += "CUSTO : " + vl_custoTextBox.Text + (char)10 + (char)10;
            strDados += "VENDA: " + vl_vendaTextBox.Text + (char)10 + (char)10;
            objimpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 50, 50);
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            FrmPesquisaProduto fpu = new FrmPesquisaProduto();
            fpu.ShowDialog();
            cod = fpu.getCodigo();
            if (cod > 0)
            {
                reg = tbprodutoBindingSource.Find("cd_produto", cod);
                tbprodutoBindingSource.Position = reg;
            }
        }
    }
}
