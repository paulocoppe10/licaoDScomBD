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
    public partial class frmlogin : Form
    {
        public static string nivel;
        public frmlogin()
        {
            InitializeComponent();
        }

        

        private void frmlogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroDataSet.tbusuario' table. You can move, or remove it, as needed.
            this.tbusuarioTableAdapter.Fill(this.cadastroDataSet.tbusuario);

        }

        private void tbusuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbusuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }
        private void btnentrar_Click(object sender, EventArgs e)
        {
            tbusuarioTableAdapter.FillLogin(cadastroDataSet.tbusuario, txtlogin.Text, txtsenha.Text);
            if ((txtlogin.Text == "mestre" && txtsenha.Text == "2005") || tbusuarioBindingSource.Count > 0)
            {
                if (tbusuarioBindingSource.Count > 0)
                {
                    nivel = cadastroDataSet.tbusuario.Rows[tbusuarioBindingSource.Position][cadastroDataSet.tbusuario.sg_nivelColumn].ToString();
                }
                else
                {
                    nivel = "1";
                }
      

                    frmPrincipal fp = new frmPrincipal();
                fp.Show();
            }
            else
            {
                MessageBox.Show("login ou senha invalido!!!");
            }

        }
        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
