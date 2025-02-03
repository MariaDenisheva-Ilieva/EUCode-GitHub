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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Линк към викторината
            string quizLink = "https://view.genially.com/670d8681d6f1ffae745f9e93/interactive-content-code-quiz";

            // Отваря линка в браузъра по подразбиране
            Process.Start(new ProcessStartInfo
            {
                FileName = quizLink,
                UseShellExecute = true // Това гарантира, че ще се отвори в браузър
            });
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // URL на видеото в YouTube
            string youtubeUrl = "https://www.youtube.com/watch?v=PyYYBRMVJrw";

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
            string youtubeUrl = "https://www.youtube.com/watch?v=-olwaPz2sAc";

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
            string youtubeUrl = "https://www.youtube.com/watch?v=LGuCPMnEf1w";

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
            string youtubeUrl = "https://www.youtube.com/watch?v=KIztWW28DYk";

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
            string youtubeUrl = "https://www.youtube.com/watch?v=SHk-NZrPrjI";

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
            string youtubeUrl = "https://www.youtube.com/watch?v=vL5wZ08EHvk";

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Линк към викторината
            string quizLink = "https://learningapps.org/watch?v=p4j8ciuj524";

            // Отваря линка в браузъра по подразбиране
            Process.Start(new ProcessStartInfo
            {
                FileName = quizLink,
                UseShellExecute = true // Това гарантира, че ще се отвори в браузър
            });
        }
    }
}
