using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // Необходимо за Process.Start()

namespace Диалог
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Линк към викторината
            string quizLink = "https://learningapps.org/watch?v=p8eysk5s524";

            // Отваря линка в браузъра по подразбиране
            Process.Start(new ProcessStartInfo
            {
                FileName = quizLink,
                UseShellExecute = true // Това гарантира, че ще се отвори в браузър
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // URL на видеото в YouTube
            string youtubeUrl = "https://www.youtube.com/watch?v=_0oelUSFxPU";

            // Отваряне на видеото в стандартния браузър
            try
            {
                System.Diagnostics.Process.Start(youtubeUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не може да се отвори видеото: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // URL на видеото в YouTube
            string youtubeUrl = "https://www.youtube.com/watch?v=TBRwOPo_tAo";

            // Отваряне на видеото в стандартния браузър
            try
            {
                System.Diagnostics.Process.Start(youtubeUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не може да се отвори видеото: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // URL на видеото в YouTube
            string youtubeUrl = "https://www.youtube.com/watch?v=N3KahTasV9o";

            // Отваряне на видеото в стандартния браузър
            try
            {
                System.Diagnostics.Process.Start(youtubeUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не може да се отвори видеото: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // URL на видеото в YouTube
            string youtubeUrl = "https://www.youtube.com/watch?v=Bqi1zhUfJMw";

            // Отваряне на видеото в стандартния браузър
            try
            {
                System.Diagnostics.Process.Start(youtubeUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не може да се отвори видеото: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // URL на видеото в YouTube
            string youtubeUrl = "https://www.youtube.com/watch?v=oapKQandvrY";

            // Отваряне на видеото в стандартния браузър
            try
            {
                System.Diagnostics.Process.Start(youtubeUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не може да се отвори видеото: " + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // URL на видеото в YouTube
            string youtubeUrl = "https://www.youtube.com/watch?v=KGQOA505m_o";

            // Отваряне на видеото в стандартния браузър
            try
            {
                System.Diagnostics.Process.Start(youtubeUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не може да се отвори видеото: " + ex.Message);
            }
        }
    }
}
