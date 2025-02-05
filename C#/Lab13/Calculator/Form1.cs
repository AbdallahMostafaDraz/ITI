namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (operationFlag)
            {
                TextCalculator.Clear();
                operationFlag = false;
            }

            TextCalculator.Text += b.Text;
        }

        char operation;
        float num1;
        bool operationFlag = false;
        private void button13_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            operation = char.Parse(b.Text);
            num1 = float.Parse(TextCalculator.Text);
            operationFlag = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            float result = 0;
            if (operation == '+')
                result = num1 + float.Parse(TextCalculator.Text);
            else if (operation == '-')
                result = num1 - float.Parse(TextCalculator.Text);
            else if (operation == 'X')
                result = num1 * float.Parse(TextCalculator.Text);
            else if (operation == '/')
                if (int.Parse(TextCalculator.Text) == 0)
                    MessageBox.Show("Canno't Divide By Zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    result = num1 / float.Parse(TextCalculator.Text);
            else if (operation == '%')
                result = num1 % float.Parse(TextCalculator.Text);

            TextCalculator.Text = result.ToString();
            operationFlag = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dotBTN_Click(object sender, EventArgs e)
        {
            if (!TextCalculator.Text.Contains("."))
                TextCalculator.Text += ".";
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            TextCalculator.Clear();
        }

        private void TextCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox t = sender as TextBox;
            e.Handled = true;
            if (char.IsDigit(e.KeyChar))
                t.Text += e.KeyChar;
            else
                MessageBox.Show("Only Numbers Allowed!");
        }
    }
}
