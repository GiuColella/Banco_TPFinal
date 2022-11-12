using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heladeria.CPresentacion
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            pnlDatosP.Visible = false;
            pnlInicio.Visible = true;
            pnlInverciones.Visible = false;

        }

        private void btnDatosP_Click(object sender, EventArgs e)
        {
            pnlDatosP.Visible = true;
            pnlInicio.Visible = false;
            pnlInverciones.Visible =false;
        }

        private void btnInverciones_Click(object sender, EventArgs e)
        {
            pnlDatosP.Visible = false;
            pnlInicio.Visible = false;
            pnlInverciones.Visible = true;

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void pnlDatosP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlInverciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblIngresoMontoInversion_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

            frmLogin frmlogin = new frmLogin();
            frmlogin.Show();
            this.Hide();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void pnlInverciones_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
