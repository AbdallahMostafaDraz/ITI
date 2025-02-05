namespace Registraion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
                MessageBox.Show("Passwords Are Not Matched!", "Incorred Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show($"Registration Data:\n\tID: {txtID.Text}\n\t" +
                    $"Name: {txtName.Text}\n\tAge: {txtAge.Text}\n\t" +
                    $"Address: {txtAddress.Text}\n\tPhone: {txtPhone.Text}\n\t" +
                    $"Email: {txtEmail.Text}", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox t = sender as TextBox;
            e.Handled = true;
            if (char.IsDigit(e.KeyChar))
                t.Text += e.KeyChar;
            else
                MessageBox.Show("Only Numbers Allowed!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
