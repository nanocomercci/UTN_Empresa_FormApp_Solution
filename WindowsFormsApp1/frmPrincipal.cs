using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Quiere salir del sistema?", "Salir", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpelado frmempleado = new frmEmpelado();
            frmempleado.MdiParent = this;
            frmempleado.Show();

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente frmcliente = new frmCliente();
            frmcliente.MdiParent = this;
            frmcliente.Show();
        }
    }
}
