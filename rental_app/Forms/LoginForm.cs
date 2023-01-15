using Microsoft.EntityFrameworkCore;
using rental_app.Data;
using rental_app.Forms;
using rental_app.Models;

namespace rental_app
{

    public partial class LoginForm : Form
    {
        RentalAppContext context = new RentalAppContext();
        public LoginForm()
        {
            InitializeComponent();
            errorLabel.Text = "";
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registerForm = new RegisterForm();
            registerForm.Closed += (s, args) => this.Close();
            registerForm.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Customer customer = context.Customers.SingleOrDefault(c => c.Username == usernameTextBox.Text
                                                                && c.Password == passwordTextBox.Text);
            if(customer != null)
            {
                this.Hide();
                var controlForm = new ControlForm();
                controlForm.Closed += (s, args) => this.Close();
                controlForm.Show();
            }
            else
            {
                errorLabel.Text = "Bad username or password!";
            }
        }
    }
}