// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;
using System.Xml.Linq;

Console.WriteLine("Практическая 1");

            Console.WriteLine("Учет потраченных средств");
Console.WriteLine("Ввод количества операций от 2 до 40");
int n; // Кол-во трат
bool a = int.TryParse(Console.ReadLine(),out n);
    while (!a || (n < 2 || n > 40))
{
    Console.WriteLine("Введи корректное число");
    a = int.TryParse(Console.ReadLine(), out n);
}

Console.WriteLine("Значение принято");

Console.WriteLine("Введите данные о расходах в формате: Название; Сумма");

string[] items = new string[n]; // Массив наименований
decimal[] amount_sum = new decimal[n]; // Массив Сумм

for (int i = 0; i < n; i++)
{
    Console.Write($"Операция {i + 1}: ");

    string input = Console.ReadLine();

    string[] parts = input.Split(';');

    string item = parts[0].Trim();

    Console.WriteLine(item);

    items[i] = item;




    //   int amount;


    //  items[i] = item;
    //  amount_sum[i] = amount;
}
foreach (var i in items)
{
    Console.WriteLine(i);
}






