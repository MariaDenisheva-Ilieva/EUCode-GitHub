using System;

namespace PoznajLicetoNaKvadratC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добре дошли в играта 'Познай лицето и периметъра на правоъгълник'!");

        // Въвеждане на дължините на страните от потребителя
        Console.Write("Въведете дължина на правоъгълника: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Въведете ширина на правоъгълника: ");
        double width = double.Parse(Console.ReadLine());

        // Изчисление на лицето 
        double area = length * width;
        
        // Предположение на потребителя за лицето на правоъгълника
        Console.Write("Познайте лицето на правоъгълника: ");
        double userGuessArea = double.Parse(Console.ReadLine());

        // Проверка на правилността на предположението и отпечатване на резултатите
        if (userGuessArea == area)
        {
            Console.WriteLine("Браво! Вие познахте лицето на правоъгълника!");
        }
        else
        {
            Console.WriteLine($"Грешка. Правилното лице на правоъгълника е {area}.");
        }

        
    }
}
}
