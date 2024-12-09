using System;
using System.Text.RegularExpressions;


namespace Project;

class Program {
    static void Main() {
        Console.WriteLine("Введите опцию: \n1 Калькулятор \n2 Угадай число");
        switch (int.Parse(Console.ReadLine())) {
            case 1:
                Console.WriteLine("Введите первое число:");
                int first_number = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                int second_number = int.Parse(Console.ReadLine());
                
                Console.WriteLine($"Сумма: {first_number + second_number}");
                break;
            case 2:
                Random random = new Random();
                int random_number = random.Next(1, 11);
                Console.WriteLine("Угадай число от 1 до 10");
                if (random_number == int.Parse(Console.ReadLine())) {
                    Console.WriteLine("Ты угадал");
                } else {
                    Console.WriteLine($"Ты не угадал. Загаданное число {random_number}");
                }
                break;
        }
    }
}