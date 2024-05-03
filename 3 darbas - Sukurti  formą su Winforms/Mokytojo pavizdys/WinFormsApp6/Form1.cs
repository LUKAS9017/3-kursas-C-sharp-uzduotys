namespace WinFormsApp6
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
            textBox1.Text = textBox2.Text;

            DialogResult res = MessageBox.Show("Ar norite uþdaryti?", "Áspëjimas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            
            else
                       
            {
                // Do something  
            }
        }
            private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ok_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = "uzvedziau";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_ilgis_Scroll(object sender, EventArgs e)
        {
            
            textBox2.Text = pass_ilgis.Value.ToString()   ;
            progressBar1.Value = pass_ilgis.Value;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.ToString();
        }
    }
}