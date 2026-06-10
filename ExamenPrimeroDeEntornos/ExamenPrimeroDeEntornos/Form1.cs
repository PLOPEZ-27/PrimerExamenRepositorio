using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenPrimeroDeEntornos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerResumen_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("ERROR. no hay ningun nombre registrado");
            }
            else if (txtIdentidad.Text == string.Empty)
            {
                MessageBox.Show("ERROR. no hay ningun DNI registrado");
            }
            else if (txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("ERROR. no hay ningun Numero de telefono registrado");
            }
            else if (cbmVehiculo.Text == string.Empty)
            {
                MessageBox.Show("ERROR. no hay ningun vehiuclo registrado");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtIdentidad.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            cbmVehiculo.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
