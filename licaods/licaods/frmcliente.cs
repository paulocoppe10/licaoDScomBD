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
    public partial class frmcliente : Form
    {
        private void Habilita()
        {
            cd_clienteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nr_numeroTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_telefoneTextBox.Enabled = true;
            cd_cpfMaskedTextBox.Enabled = true;
            cd_rgTextBox.Enabled = true;
            ds_emailTextBox.Enabled = true;

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
            cd_clienteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nr_numeroTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            cd_cepTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_telefoneTextBox.Enabled = false;
            cd_cpfMaskedTextBox.Enabled = false;
            cd_rgTextBox.Enabled = false;
            ds_emailTextBox.Enabled = false;


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

        public frmcliente()
        {
            InitializeComponent();
        }

        private void frmcliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroDataSet.tbcliente' table. You can move, or remove it, as needed.
            this.tbclienteTableAdapter.Fill(this.cadastroDataSet.tbcliente);
            Desabilita();

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnalterar_Click_1(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.MovePrevious();
        }

        private void btnproximo_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.MoveNext();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.AddNew();
            Habilita();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.RemoveCurrent();
            tbclienteTableAdapter.Update(cadastroDataSet.tbcliente);
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            bool valida = true;
            int soma = 0, dig;
            soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(10, 1)) * 2;
            soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(9, 1)) * 3;
            soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(8, 1)) * 4;
            soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(6, 1)) * 5;
            soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(5, 1)) * 6;
            soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(4, 1)) * 7;
            soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(2, 1)) * 8;
            soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(1, 1)) * 9;
            soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(0, 1)) * 10;
            dig = soma % 11;
            if (dig < 2)
            {
                dig = 0;
            }
            else
            {
                dig = 11 - dig;
            }

            if(int.Parse(cd_cpfMaskedTextBox.Text.Substring(12, 1)) == dig)
            {
                soma = 0;
                soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(12, 1)) * 2;
                soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(10, 1)) * 3;
                soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(9, 1)) * 4;
                soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(8, 1)) * 5;
                soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(6, 1)) * 6;
                soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(5, 1)) * 7;
                soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(4, 1)) * 8;
                soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(2, 1)) * 9;
                soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(1, 1)) * 10;
                soma += int.Parse(cd_cpfMaskedTextBox.Text.Substring(0, 1)) * 11;
                dig = soma % 11;
                if (dig < 2)
                {
                    dig = 0;
                }
                else
                {
                    dig = 11 - dig;
                }

                if (int.Parse(cd_cpfMaskedTextBox.Text.Substring(13, 1)) != dig)
                {
                    MessageBox.Show("CPF invalido");
                    cd_cpfMaskedTextBox.Focus();
                    valida = false;
                }                
            }
            else
            {
                MessageBox.Show("CPF invalido");
                cd_cpfMaskedTextBox.Focus();
            }

         
            if (valida)
            { 
            Validate();
            tbclienteBindingSource.EndEdit();
            tbclienteTableAdapter.Update(cadastroDataSet.tbcliente);
            Desabilita();
        }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.CancelEdit();
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
            strDados = "FICHA CLENTE" + (char)10 + (char)10;
            strDados += "CODIGO: " + cd_clienteTextBox.Text + (char)10 + (char)10;
            strDados += "NOME CLIENTE: " + nm_clienteTextBox.Text + (char)10 + (char)10;
            strDados += "ENDEREÇO: " + ds_enderecoTextBox.Text + (char)10 + (char)10;
            strDados += "NUMERO: " + nr_numeroTextBox.Text + (char)10 + (char)10;
            strDados += "BAIRRO: " + nm_bairroTextBox.Text + (char)10 + (char)10;
            strDados += "CIDADE: " + nm_cidadeTextBox.Text + (char)10 + (char)10;
            strDados += "CEP " + cd_cepTextBox.Text + (char)10 + (char)10;
            strDados += "ESTADO " + sg_estadoTextBox.Text + (char)10 + (char)10;
            strDados += "TELEFONE " + cd_telefoneTextBox.Text + (char)10 + (char)10;
            strDados += "CPF " + cd_cpfMaskedTextBox.Text + (char)10 + (char)10;
            strDados += "RG " + cd_rgTextBox.Text + (char)10 + (char)10;
            strDados += "EMAIL " + ds_emailTextBox.Text + (char)10 + (char)10;
            objimpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 50, 50);
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmPesquisaCliente fpu = new frmPesquisaCliente();
            fpu.ShowDialog();
            cod = fpu.getCodigo();
            if (cod > 0)
            { 
                reg = tbclienteBindingSource.Find("cd_cliente", cod);
                tbclienteBindingSource.Position = reg;
            }
        }
    }
}
