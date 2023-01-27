using Microsoft.IdentityModel.Tokens;
using rental_app.Data;
using rental_app.Models;

namespace rental_app.Forms
{
    public partial class RegisterForm : Form
    {
        RentalAppContext context = new RentalAppContext();
        public RegisterForm()
        {
            InitializeComponent();
            errorLabel.Text = "";
        }
        bool isIllegalCharInInput(String input)
        {
            return input.IsNullOrEmpty() || !input.All(Char.IsLetterOrDigit);
        }
        public bool inputValidator()
        {
            errorLabel.Text = "";
            bool hasErrorOccured = false;
            if (isIllegalCharInInput(usernameTextBox.Text))
            {
                errorLabel.Text += " username, ";
                hasErrorOccured = true;
            }
            if (isIllegalCharInInput(passwordTextBox.Text))
            {
                errorLabel.Text += " password, ";
                hasErrorOccured = true;
            }
            if (isIllegalCharInInput(nameTextBox.Text))
            {
                errorLabel.Text += " name, ";
                hasErrorOccured = true;
            }
            if (isIllegalCharInInput(surnameTextBox.Text))
            {
                errorLabel.Text += " surname, ";
                hasErrorOccured = true;
            }
            if(dateOfBirthPicker.Value.Date > DateTime.Now)
            {
                errorLabel.Text += " date of birth";
                hasErrorOccured = true;
            }
            if (hasErrorOccured)
            {
               errorLabel.Text = errorLabel.Text.Insert(0, "Bad input at: ");
            }
            return hasErrorOccured;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (!inputValidator())
            {
                Customer customer = new Customer()
                {
                    Username = usernameTextBox.Text,
                    Password = passwordTextBox.Text,
                    Name = nameTextBox.Text,
                    Surname = surnameTextBox.Text,
                    DateOfBirth = dateOfBirthPicker.Value.Date
                };
                context.Add(customer);
                context.SaveChanges();
                errorLabel.Text = "";
                MessageBox.Show("Registration successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }
    }
}
