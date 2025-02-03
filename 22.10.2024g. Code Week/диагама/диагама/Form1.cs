using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace диагама
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(); // Създаваш нова инстанция на Form2
            newForm.Show(); // Показваш Form2
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3(); // Създаваш нова инстанция на Form3
            newForm.Show(); // Показваш Form3
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4(); // Създаваш нова инстанция на Form4
            newForm.Show(); // Показваш Form4
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5(); // Създаваш нова инстанция на Form5
            newForm.Show(); // Показваш Form5
        }
    }
}
