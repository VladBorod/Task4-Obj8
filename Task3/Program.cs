// Задача 3.
// Программа принимающая число и определяющая, является ли число четным.

Console.Clear();

// Ввод числового значения.

Console.WriteLine("Even / odd number definition.");
Console.Write("Enter the number: ");
decimal number = decimal.Parse(Console.ReadLine());

/*
    Производим целочисленное деление,
    с вычислением остатка.
    В случае если остаток (%) = 0 - число четное (Even).
    В случае если остаток (%) не равен 0 - не четное (Odd).
*/

if (number % 2 == 0)
{
    // YES!
    Console.WriteLine($"Even number = {number}");
}
else 
{
    // NO!
    Console.WriteLine($"Odd number = {number}");
}