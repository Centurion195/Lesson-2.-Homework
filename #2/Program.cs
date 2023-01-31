// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите два числа: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if (num1==num2*num2 || num2==num1*num1)
Console.WriteLine("Одно число является квадратом другого.");
else
Console.WriteLine("Ни одно из чисел не является квадратом другого.");