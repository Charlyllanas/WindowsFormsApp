using WinFormsApp5.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using WinFormsApp5.Sesion;
using System.Diagnostics;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            //txtPassword.Text = "1234";
            //txtUser.Text = "19040077";
        }

        Context Methods = new Context();

        private void button1_Click(object sender, EventArgs e)
        {
            var user = txtUser.Text.Trim();
            var password = txtPassword.Text.Trim();

            if (!String.IsNullOrEmpty(user) && !String.IsNullOrEmpty(password))
            {
                var resultLogin = Methods.Login(user, password);
                if (resultLogin.valid)
                {
                    // open new form

                    if (resultLogin.type == 1)
                    {

                        this.Hide();

                        Sesion.Session.SessionName = user;
                
                        //Open Form Alumn
                        FormAlmuns formAlumns = new FormAlmuns();
                        formAlumns.Show();

                    }
                    else if (resultLogin.type == 2)
                    {
                        //Open Form Teacher
                        MessageBox.Show("Usted es profesor");
                    }
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos");
            }

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();

        }
    }
}