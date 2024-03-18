namespace Chapter3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "hahahahahaha,,,";
            label1.Text = Double.Parse(textBox1.Text).ToString();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}