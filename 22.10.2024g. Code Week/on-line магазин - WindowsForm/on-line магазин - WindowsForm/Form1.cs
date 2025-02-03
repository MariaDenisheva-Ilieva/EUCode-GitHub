using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace on_line_магазин___WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Цените на продуктите
        private double priceBoots = 120.00;
        private double priceBlouse = 50.00;
        private double priceJacket = 180.00;
        private double priceJeans = 75.00;
        private double priceBag = 110.00;

        private void button6_Click(object sender, EventArgs e)
        {
            // Инициализиране на общата сума
            double totalPrice = 0.00;

            // Проверка кои продукти са избрани и добавяне на цените им към общата сума
            if (checkBox1.Checked)
            {
                totalPrice += priceBoots;
            }

            if (checkBox2.Checked)
            {
                totalPrice += priceBlouse;
            }

            if (checkBox3.Checked)
            {
                totalPrice += priceJacket;
            }

            if (checkBox4.Checked)
            {
                totalPrice += priceJeans;
            }

            if (checkBox4.Checked)
            {
                totalPrice += priceBag;
            }

            // Показване на общата сума в label2
            label8.Text = $"{totalPrice} лв.";
        }
    }
}
