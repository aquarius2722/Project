namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string address = textBox2.Text;
            string password = textBox3.Text;
            string confirmPassword = textBox4.Text;
            string email = textBox5.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }


            MessageBox.Show("Registration successful!");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            // Check if username and password are valid
            if (username == "admin" && password == "admin")
            {     // sa una lang na... ang ika duwa mo nga task eh save mo sa github din na ang git hub haw
                MessageBox.Show("Login successful!");
                // Open the main application or perform other actions here
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
                // Clear password field for security purposes
                txtpassword.Clear();
                // Set focus to the password field
                txtpassword.Focus();
            }
        }
    }
}
