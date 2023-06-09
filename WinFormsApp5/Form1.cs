using WinFormsApp5.Entity;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Context Methods = new Context();

        private void button1_Click(object sender, EventArgs e)
        {
            //var user = txtUser.Text.Trim();
            //var password = txtPassword.Text.Trim();
            var user = "19040077";
            var password = "1234";

            if (!String.IsNullOrEmpty(user) && !String.IsNullOrEmpty(password))
            {
                var resultLogin = Methods.Login(user, password, validresultQuery);
                if (resultLogin.valid)
                {
                    this.Hide();
                    // open new form

                    if (resultLogin.type != 1)
                    {
                        //Open Form Alumn

                    }
                    else
                    {
                        //Open Form Teacher
                    }
                }
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
    }
}