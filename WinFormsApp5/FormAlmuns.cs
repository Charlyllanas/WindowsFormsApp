using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class FormAlmuns : Form
    {
        public FormAlmuns()
        {
            InitializeComponent();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            // Crear instancia del formulario alterno
            FormAlmuns formularioDescripcion = new FormAlmuns();

            // Establecer la posición del formulario alterno
            formularioDescripcion.Location = new Point(this.Location.X + this.Width, this.Location.Y + (this.Height - formularioDescripcion.Height) / 2);

            // Mostrar el formulario alterno
            formularioDescripcion.Show();
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            // Cerrar el formulario alterno
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
