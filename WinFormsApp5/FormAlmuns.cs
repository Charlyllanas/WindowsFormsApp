using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp5.Entity;

namespace WinFormsApp5
{
    public partial class FormAlmuns : Form
    {
        MainMethods contextMethods = new MainMethods();
        public FormAlmuns()
        {
            InitializeComponent();
        }

        private void FormAlmuns_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Sesion.Session.SessionName;
            panelIsVisible(false, 0);
            panelBtnRegistrar.Visible = false;
        }

        private void btnBecaExcelencia_MouseEnter(object sender, EventArgs e)
        {
            panelIsVisible(true, 1);
        }

        private void btnBecaDeportiva_MouseEnter(object sender, EventArgs e)
        {
            panelIsVisible(true, 2);
        }

        private void btnBecaAyuda_MouseEnter(object sender, EventArgs e)
        {
            panelIsVisible(true, 3);
        }

        private void FormAlmuns_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sesion.Session.SessionName = string.Empty;
            Form1 form1 = new Form1();
            form1.Show();
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            var existRegistroBeca = await contextMethods.existeBeca(Sesion.Session.SessionName);
            if (existRegistroBeca == 0)
            {
                if (panelBecaExcelencia.Visible)
                {
                    if (!String.IsNullOrEmpty(txtCorreoExcelencia.Text.Trim()) && !String.IsNullOrEmpty(txtPromedioExcelencia.Text.Trim()))
                    {
                        await contextMethods.solicitudBecaExcelencia(Sesion.Session.SessionName,
                            txtCorreoExcelencia.Text.Trim(),
                            int.Parse(txtPromedioExcelencia.Text.Trim()),
                            1);
                    }
                    else
                    {
                        MessageBox.Show("Todos los campos son requeridos");
                    }

                }
                else if (panelBecaDeportiva.Visible)
                {
                    if (!String.IsNullOrEmpty(textCorreoDeportiva.Text.Trim()) && !String.IsNullOrEmpty(txtPromedioDeportiva.Text.Trim()) && !String.IsNullOrEmpty(cmbClubDeportiva.Text.Trim()))
                    {
                        await contextMethods.solicitudBecaDeportiva(Sesion.Session.SessionName,
                             textCorreoDeportiva.Text.Trim(),
                             int.Parse(txtPromedioDeportiva.Text.Trim()),
                             2,
                             cmbClubDeportiva.Text.Trim());
                    }
                    else
                    {
                        MessageBox.Show("Todos los campos son requeridos");
                    }
                }
                else if (panelBecaAyuda.Visible)
                {
                    if (!String.IsNullOrEmpty(textCorreoAyuda.Text) && !String.IsNullOrEmpty(txtPromedioAyuda.Text) && !String.IsNullOrEmpty(txtIngresoMensualAyuda.Text))
                    {
                        await contextMethods.solicitudBecaAyuda(Sesion.Session.SessionName,
                                 textCorreoAyuda.Text.Trim(),
                                 int.Parse(txtPromedioAyuda.Text.Trim()),
                                 3,
                                 int.Parse(txtIngresoMensualAyuda.Text.Trim()));
                    }
                    else
                    {
                        MessageBox.Show("Todos los campos son requeridos");
                    }
                }
            }
            else
            {
                MessageBox.Show("Usted ya ha registrado la solocitud de una beca");
            }
            cleanTextBox();
        }

        public void panelIsVisible(bool panelVisible, int numberPanel)
        {
            if (numberPanel == 1)
            {
                btnBecaExcelencia.TabStop = true;
                panelBecaExcelencia.Visible = panelVisible;
                panelBecaDeportiva.Visible = false;
                panelBecaAyuda.Visible = false;

                panelBecaExcelencia.Width = 617;
                panelBecaExcelencia.Height = 165;
            }
            else if (numberPanel == 2)
            {
                btnBecaDeportiva.TabStop = true;
                panelBecaDeportiva.Visible = panelVisible;
                panelBecaExcelencia.Visible = false;
                panelBecaAyuda.Visible = false;

                panelBecaAyuda.Width = 617;
                panelBecaAyuda.Height = 165;
            }
            else if (numberPanel == 3)
            {
                btnBecaAyuda.TabStop = true;
                panelBecaDeportiva.Visible = false;
                panelBecaExcelencia.Visible = false;
                panelBecaAyuda.Visible = panelVisible;
                panelBecaDeportiva.Width = 617;
                panelBecaDeportiva.Height = 165;
            }
            else
            {

                btnBecaAyuda.TabStop = false;
                btnBecaDeportiva.TabStop = false;
                btnBecaExcelencia.TabStop = false;
                panelBecaDeportiva.Visible = false;
                panelBecaAyuda.Visible = false;
                panelBecaExcelencia.Visible = false;
            }
            panelBtnRegistrar.Visible = true;
        }

        private void txtPromedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPromedioAyuda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBecaDeportiva_Click(object sender, EventArgs e)
        {

        }

        private void txtPromedioDeportiva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void cleanTextBox()
        {
            txtCorreoExcelencia.Text = string.Empty;
            txtPromedioExcelencia.Text = string.Empty;
            textCorreoDeportiva.Text = string.Empty;
            txtPromedioDeportiva.Text = string.Empty;
            txtPromedioAyuda.Text = string.Empty;
            textCorreoAyuda.Text = string.Empty;
            txtIngresoMensualAyuda.Text = string.Empty;
            cmbClubDeportiva.SelectedIndex = 0;

        }

        private void txtIngresoMensualAyuda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
