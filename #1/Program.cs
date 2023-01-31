// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите номер дня недели: ");
char day = Convert.ToChar(Console.ReadLine());
if (day<'8')
{
    if (day=='6' || day=='7')
    Console.WriteLine("Этот день выходной.");
    else
    Console.WriteLine("Этот день не выходной.");
}
else
Console.WriteLine("Такого дня недели нет!");
