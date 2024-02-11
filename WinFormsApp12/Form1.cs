using Microsoft.VisualBasic.FileIO;
using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        List<string> userData = new List<string>();
        string gender = "";
        string code = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(textBox2.Text))
            {
                label6.Text = "Error:fill in the fields";

            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                label6.Text = "Error:fill in the fields";

            }
            else

            {
                userData.Add(textBox2.Text);
                userData.Add(textBox1.Text);
                userData.Add(gender);
                userData.Add(code);
                foreach (var item in userData)
                {
                    listView1.Items.Add(item);
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                gender = "male";
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                gender = "female";
                checkBox1.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox3.Checked)
            {
                code = "C#";
                checkBox4.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox4.Checked)
            {
                code = "ASP";
                checkBox3.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(80, 0, 0, 0);
        }
    }
}

