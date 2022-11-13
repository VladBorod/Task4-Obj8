// Задача 4.
/*
    Программа принимающая число (N) и выводящая все четные числа 
    от 1 до (N).
*/

Console.Clear();

// Ввод числового значения.

Console.WriteLine("Search of even numbers.");
Console.Write("Enter the number: ");
decimal number = decimal.Parse(Console.ReadLine());

/* 
    Создаем цикл.
*/

while(number >= 1)
{
/*
    Производим целочисленное деление,
    с вычислением остатка.
    В случае если остаток (%) = 0 - число четное (Even).
    Запоминаем данное число.
*/

if (number % 2 == 0)
{
    // YES!
    Console.WriteLine($"Subsequence of even numbers = {number}");
}
else 
{
    // NO!
}
number--;
}

