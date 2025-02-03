using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace он_лайн_магазин_конзола
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            // Деклариране на цените за всеки продукт
            double priceBoots = 120.00;
            double priceBlouse = 50.00;
            double priceJacket = 180.00;
            double priceJeans = 75.00;
            double priceBag = 110.00;

            // Променлива за общата сума
            double totalPrice = 0.00;

            // Въведение
            Console.WriteLine("Добре дошли в on-line магазина на 11 клас!");
            Console.WriteLine("Моля, изберете продуктите, които искате да закупите (отговорете с 'да' или 'не').\n");

            // Поредица от въпроси за всеки продукт
            Console.Write("Боти - 120 лв. Желаете ли да ги добавите? ");
            string input = Console.ReadLine();
            if (input == "da")
            {
                totalPrice += priceBoots;
            }

            Console.Write("Блуза - 50 лв. Желаете ли да я добавите? ");
            input = Console.ReadLine();
            if (input == "da")
            {
                totalPrice += priceBlouse;
            }

            Console.Write("Яке - 180 лв. Желаете ли да го добавите? ");
            input = Console.ReadLine();
            if (input == "da")
            {
                totalPrice += priceJacket;
            }

            Console.Write("Дънки - 75 лв. Желаете ли да ги добавите? ");
            input = Console.ReadLine();
            if (input == "da")
            {
                totalPrice += priceJeans;
            }

            Console.Write("Чанта - 110 лв. Желаете ли да я добавите? ");
            input = Console.ReadLine();
            if (input == "da")
            {
                totalPrice += priceBag;
            }

            // Показване на крайната сума
            Console.WriteLine("Крайната сума е: {0} лв.", totalPrice);
            Console.WriteLine("Благодарим Ви за покупката! Довиждане!");

        }
    }
}
 