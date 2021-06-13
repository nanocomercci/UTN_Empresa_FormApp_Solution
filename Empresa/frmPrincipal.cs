using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Quiere salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes) 
            {
                this.Close();
            }
            
        }
          

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmcliente = new frmCliente();
            frmcliente.MdiParent = this;
            frmcliente.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleado frmempleado = new frmEmpleado();
            frmempleado.MdiParent = this;
            frmempleado.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin frmlogin = new frmLogin();
            frmlogin.MdiParent = this;
            frmlogin.Show();


        }
    }
}
