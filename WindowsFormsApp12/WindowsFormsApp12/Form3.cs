using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Form4 Fuckthis = new Form4();
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        //Start
        private void button1_Click(object sender, EventArgs e)
        {
            
            Fuckthis.Show();
        }
        //ga terug
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Naam1 = textBox1.Text;
            Fuckthis.NaamText = Naam1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
