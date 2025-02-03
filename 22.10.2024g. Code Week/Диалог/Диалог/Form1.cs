using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Диалог
{
    public partial class Form1 : Form
    {
        // Индекс за проследяване на реда в диалога
        private int dialogStep = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Започва диалога, като първият звук е от момичето
            PlayNextDialog();

            // Метод за възпроизвеждане на следващата стъпка от диалога
            void PlayNextDialog()
            {
                SoundPlayer player = null;

                // Използваме switch-case за контролиране на последователността на диалога
                switch (dialogStep)
                {
                    case 0:
                        // Момичето казва  - g1.wav
                        player = new SoundPlayer("a1.wav");
                        dialogStep++; // Преминаваме към следващата стъпка
                        break;
                    case 1:
                        // Момчето отговаря  - b1.wav
                        player = new SoundPlayer("p1.wav");
                        dialogStep++; // Преминаваме към следващата стъпка
                        break;
                    case 2:
                        // Момчето казва g2.wav
                        player = new SoundPlayer("a2.wav");
                        dialogStep++; // Преминаваме към следващата стъпка
                        break;
                    case 3:
                        // Момичето отговаря  - b2.wav
                        player = new SoundPlayer("p2.wav");
                        dialogStep++;
                        break;
                    case 4:
                        // Момчето казва g2.wav
                        player = new SoundPlayer("a3.wav");
                        dialogStep++; // Преминаваме към следващата стъпка
                        break;
                    case 5:
                        // Момичето отговаря  - b2.wav
                        player = new SoundPlayer("p3.wav");
                        dialogStep = 0;
                        break;
                }

                if (player != null)
                {
                    player.Play(); // Възпроизвеждаме звука асинхронно
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Започва диалога, като първият звук е от момичето
            PlayNextDialog();

            // Метод за възпроизвеждане на следващата стъпка от диалога
            void PlayNextDialog()
            {
                SoundPlayer player = null;

                // Използваме switch-case за контролиране на последователността на диалога
                switch (dialogStep)
                {
                    case 0:
                        // Момичето казва  - g1.wav
                        player = new SoundPlayer("a1.wav");
                        dialogStep++; // Преминаваме към следващата стъпка
                        break;
                    case 1:
                        // Момчето отговаря  - b1.wav
                        player = new SoundPlayer("p1.wav");
                        dialogStep++; // Преминаваме към следващата стъпка
                        break;
                    case 2:
                        // Момчето казва g2.wav
                        player = new SoundPlayer("a2.wav");
                        dialogStep++; // Преминаваме към следващата стъпка
                        break;
                    case 3:
                        // Момичето отговаря  - b2.wav
                        player = new SoundPlayer("p2.wav");
                        dialogStep++;
                        break;
                    case 4:
                        // Момчето казва g2.wav
                        player = new SoundPlayer("a3.wav");
                        dialogStep++; // Преминаваме към следващата стъпка
                        break;
                    case 5:
                        // Момичето отговаря  - b2.wav
                        player = new SoundPlayer("p3.wav");
                        dialogStep = 0;
                        break;
                }

                if (player != null)
                {
                    player.Play(); // Възпроизвеждаме звука асинхронно
                }


            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Създаване на обект на Form2
            Form2 form2 = new Form2();

            // Показване на Form2
            form2.Show(); // Показва Form2 като отделен прозорец
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Създаване на обект на Form4
            Form4 form4 = new Form4();

            // Показване на Form4
            form4.Show(); // Показва Form2 като отделен прозорец
        }
    }
    }
    

