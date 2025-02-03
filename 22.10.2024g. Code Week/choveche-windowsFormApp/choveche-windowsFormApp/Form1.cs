using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace choveche_windowsFormApp
{
    public partial class Form1 : Form
    {
        private bool isSmiling = false; // Флаг за усмивка или неутрално изражение
        private Color faceColor = Color.Yellow; // Начален цвят на лицето
        public Form1()
        {
            InitializeComponent();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Рисуване на човечето в PictureBox
            using (Graphics g = pictureBox1.CreateGraphics())
            {
                // Размер на лицето (жълтия кръг)
                int faceWidth = 200;
                int faceHeight = 200;

                // Изчисляване на централните координати за лицето
                int x = (pictureBox1.Width - faceWidth) / 2;
                int y = (pictureBox1.Height - faceHeight) / 2;

                // Настройки за четки и писци
                Pen blackPen = new Pen(Color.Black, 4); // Писец за контурите
                SolidBrush faceBrush = new SolidBrush(faceColor); // Четка за лицето (може да е променен цвят)
                SolidBrush blueBrush = new SolidBrush(Color.Blue); // Четка за очите

                // Изчистване на PictureBox
                g.Clear(Color.White);

                // Рисуване на лицето (жълт кръг с черен контур)
                g.FillEllipse(faceBrush, x, y, faceWidth, faceHeight);  // Запълнен кръг (с променлив цвят)
                g.DrawEllipse(blackPen, x, y, faceWidth, faceHeight);   // Черен контур на кръга

                // Рисуване на очите (сини кръгове)
                g.FillEllipse(blueBrush, x + 50, y + 50, 40, 40);       // Ляво око
                g.FillEllipse(blueBrush, x + 110, y + 50, 40, 40);      // Дясно око

                // Рисуване на устата (в зависимост от изражението)
                if (isSmiling)
                {
                    // Усмивка (дъга)
                    g.DrawArc(blackPen, x + 60, y + 100, 80, 50, 0, -180);
                }
                else
                {
                    // Неутрална уста (линия)
                    g.DrawLine(blackPen, x + 60, y + 120, x + 140, y + 120);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Промяна на изражението на лицето
            isSmiling = !isSmiling; // Превключване между усмивка и неутрално
            button1.PerformClick(); // Прерисуване на лицето с новото изражение
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Промяна на цвета на лицето на точно червено
            faceColor = Color.Red; // Задаване на червен цвят
            button1.PerformClick(); // Прерисуване на лицето с новия цвят
        }
    }
}

