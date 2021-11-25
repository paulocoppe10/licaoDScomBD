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
    public partial class frmusuario : Form
    {
        private void Habilita()
        {
            nm_usuarioTextBox.Enabled = true;
            cd_usuarioTextBox.Enabled = false;
            sg_nivelTextBox.Enabled = true;
            nm_loginTextBox.Enabled = true;
            cd_senhaTextBox.Enabled = true;
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
            nm_usuarioTextBox.Enabled = false;
            cd_usuarioTextBox.Enabled = false;
            sg_nivelTextBox.Enabled = false;
            nm_loginTextBox.Enabled = false;
            cd_senhaTextBox.Enabled = false;
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
        public frmusuario()
        {
            InitializeComponent();
        }

        private void frmusuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroDataSet.tbusuario' table. You can move, or remove it, as needed.
            this.tbusuarioTableAdapter.Fill(this.cadastroDataSet.tbusuario);
            Desabilita();
        }

        private void nm_loginLabel_Click(object sender, EventArgs e)
        {

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
            tbusuarioBindingSource.MovePrevious();
        }

        private void btnproximo_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.MoveNext();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.AddNew();
            Habilita();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.RemoveCurrent();
            tbusuarioTableAdapter.Update(cadastroDataSet.tbusuario);
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbusuarioBindingSource.EndEdit();
            tbusuarioTableAdapter.Update(cadastroDataSet.tbusuario);
            Desabilita();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.CancelEdit();
            Desabilita();
        }

        private void cd_usuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmPesquisaUsuario fpu = new frmPesquisaUsuario();
            fpu.ShowDialog();
            cod = fpu.getCodigo();
            if (cod>0)
            { 
            reg = tbusuarioBindingSource.Find("cd_usuario",cod);
                tbusuarioBindingSource.Position = reg;
            }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objimpressao = e.Graphics;
            strDados = "FICHA USUARIO" + (char)10 + (char)10; 
            strDados +="CODIGO: "+cd_usuarioTextBox.Text + (char)10 + (char)10;
            strDados += "NIVEL: " + sg_nivelTextBox.Text + (char)10 + (char)10;
            strDados += "NOME USUARIO: " + nm_usuarioTextBox.Text + (char)10 + (char)10;
            strDados += "LOGIN: " + nm_loginTextBox.Text + (char)10 + (char)10;
            objimpressao.DrawString(strDados,new Font("Arial",12,FontStyle.Regular),Brushes.Black,50,50);
        }
    }
}
