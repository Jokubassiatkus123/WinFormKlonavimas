using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button4.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, suma;
            num1=Convert.ToInt32(textBox1.Text);
            num2=Convert.ToInt32(textBox2.Text);
            suma=num1+num2;
            label4.Text = suma.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Ar norite išjungti programą?";
            string title = "Programos išjungimas";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                int width = Convert.ToInt32(textBox3.Text);
                int length = Convert.ToInt32(textBox4.Text);
                int area = width * length;
                int perimeter = (width + length) * 2;
                label10.Text = "Perimetras: " + perimeter;
                label11.Text = "Plotis: " + area;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listBox.GetItemText(listBox.SelectedItem);
            MessageBox.Show(text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button4.Enabled = true;
            }
            else

            { button4.Enabled = false; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Check box'as turi būti visada pažymėtas, norint paspausti mygtuką");
        }
    }
}
