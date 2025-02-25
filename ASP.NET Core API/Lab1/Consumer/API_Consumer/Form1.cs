namespace API_Consumer
{
    public partial class Form1 : Form
    {
        HttpClient httpClient = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            httpClient.BaseAddress = new Uri("https://localhost:7055/");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            
            var response = await httpClient.GetAsync("/api/Course");
            if (response.IsSuccessStatusCode)
            {
                dataGridView1.DataSource = await response.Content.ReadAsAsync<List<Course>>();
            }
            else
                MessageBox.Show("Error While Getting Data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Trim() == string.Empty) || (textBox2.Text.Trim() == string.Empty) || textBox3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill All Data!", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var course = new Course() { Crs_Name = textBox1.Text, Crs_Desc = textBox2.Text, Duration = int.Parse(textBox3.Text) };
                var response = await httpClient.PostAsJsonAsync("api/Course", course);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Course Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = textBox2.Text = textBox3.Text = "";
                }
                else
                {
                    MessageBox.Show("Error While Saving Data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
