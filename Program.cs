﻿/*Задача:
Я користувач рахунку хочу перевірити свій баланс (виведіть на консоль число 1000)
Як користувач рахунку я можу внести суму грошей на депозит. Сума може бути не цілим числом.
Якщо сума вкладу більша за 300 тоді відсоток балансу = депозит*0.5
Якщо сума вклада дорівнює чи більша за 700 тоді відсоток балансу = депозит*0.7
Я можу ввести суму лише двічі поспіль, потім виведть в консоль повідомлення про загальний баланс та завершення операцій через ліміт операцій.

Використовуйте цикли while та логічний оператор if*/


Console.Write("Баланс счета:1000 ");
Console.WriteLine("\nВведите сумму вклада: ");
double sum = Convert.ToDouble(Console.ReadLine());
double percent = 0;
if (sum > 300)
{
    percent = 0.05;
}
else if (sum => 700)
{
    percent = 0.07;
}

sum += sum * percent;

Console.WriteLine($"Сумму вклада после начисления процентов: {sum}");




/*WHILE
int count = 2;
while (count < 2)
    count++;
Console.WriteLine(count);*/





