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
    public partial class frmfornecedor : Form
    {
        private void Habilita()
        {
            cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nr_enderecoTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
            cd_telefoneTextBox.Enabled = true;
            cd_cpfTextBox.Enabled = true;
            cd_rgTextBox.Enabled = true;
            cd_cnpjTextBox.Enabled = true;
            cd_ieTextBox.Enabled = true;
            sg_tipoTextBox.Enabled = true;
            ds_emailTextBox.Enabled = true;
            nm_contatoTextBox.Enabled = true;

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
            cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nr_enderecoTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cepTextBox.Enabled = false;
            cd_telefoneTextBox.Enabled = false;
            cd_cpfTextBox.Enabled = false;
            cd_rgTextBox.Enabled = false;
            cd_cnpjTextBox.Enabled = false;
            cd_ieTextBox.Enabled = false;
            sg_tipoTextBox.Enabled = false;
            ds_emailTextBox.Enabled = false;
            nm_contatoTextBox.Enabled = false;

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


    public frmfornecedor()
        {
            InitializeComponent();
        }

        private void frmfornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroDataSet.tbfornecedor' table. You can move, or remove it, as needed.
            this.tbfornecedorTableAdapter.Fill(this.cadastroDataSet.tbfornecedor);
            Desabilita();

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            tbfornecedorBindingSource.RemoveCurrent();
            tbfornecedorTableAdapter.Update(cadastroDataSet.tbfornecedor);
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
            tbfornecedorBindingSource.MovePrevious();
        }

        private void btnproximo_Click(object sender, EventArgs e)
        {
            tbfornecedorBindingSource.MoveNext();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            tbfornecedorBindingSource.AddNew();
            Habilita();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbfornecedorBindingSource.EndEdit();
            tbfornecedorTableAdapter.Update(cadastroDataSet.tbfornecedor);
            Desabilita();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            tbfornecedorBindingSource.CancelEdit();
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
            strDados += "CODIGO: " + cd_fornecedorTextBox.Text + (char)10 + (char)10;
            strDados += "NOME FORNECEDOR : " + nm_fornecedorTextBox.Text + (char)10 + (char)10;
            strDados += "ENDEREÇO: " + ds_enderecoTextBox.Text + (char)10 + (char)10;
            strDados += "BAIRRO: " + nm_bairroTextBox.Text + (char)10 + (char)10;
            strDados += "CIDADE: " + nm_cidadeTextBox.Text + (char)10 + (char)10;
            strDados += "CEP " + cd_cepTextBox.Text + (char)10 + (char)10;
            strDados += "ESTADO " + sg_estadoTextBox.Text + (char)10 + (char)10;
            strDados += "TELEFONE " + cd_telefoneTextBox.Text + (char)10 + (char)10;
            strDados += "CPF " + cd_cnpjTextBox.Text + (char)10 + (char)10;
            strDados += "RG " + cd_rgTextBox.Text + (char)10 + (char)10;
            strDados += "EMAIL " + ds_emailTextBox.Text + (char)10 + (char)10;
            objimpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 50, 50);
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmPesquisaFornecedor fpu = new frmPesquisaFornecedor();
            fpu.ShowDialog();
            cod = fpu.getCodigo();
            if (cod > 0)
            {
                reg = tbfornecedorBindingSource.Find("cd_fornecedor", cod);
                tbfornecedorBindingSource.Position = reg;
            }
        }
    }
}
