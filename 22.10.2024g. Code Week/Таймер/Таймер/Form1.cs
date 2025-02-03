using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Таймер
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; //за да не трепти маркер след колата
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Започва таймера при натискане на бутона
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Проверка дали количката не е стигнала до края на формата
            if (pictureBox1.Left < this.Width - pictureBox1.Width - 20) // Проверява, че количката не излиза извън формата
            {
                pictureBox1.Left += 5; // Премества количката надясно с 5 пиксела
            }
            else
            {
                timer1.Stop(); // Спира таймера, ако количката стигне края
            }
           
            // Принудително прерисуване на формата, за да се изчисти старата позиция
            this.Invalidate();
        }
    }
    }

