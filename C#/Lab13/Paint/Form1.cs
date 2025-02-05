namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color color = Color.Blue;
        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
        }
        int width = 20;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                SolidBrush brush = new SolidBrush(color);
                Graphics grx = CreateGraphics();
                grx.FillEllipse(brush, e.X, e.Y, width, width);
            }
            else if (e.Button == MouseButtons.Right)
            {
                SolidBrush brush = new SolidBrush(BackColor);
                Graphics grx = CreateGraphics();
                grx.FillEllipse(brush, e.X, e.Y, width, width);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == "")
                MessageBox.Show("Enter Width!");
            else
            {
                width = int.Parse(textBox1.Text);
                textBox1.Clear();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
