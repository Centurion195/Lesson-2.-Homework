// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти в декартовой системе координат: ");
string num = Console.ReadLine();

if (num=="1" || num.ToLower()=="i")
Console.WriteLine("Возможные диапазоны координат: x>0, y>0");
else if (num=="2" || num.ToLower()=="ii")
Console.WriteLine("Возможные диапазоны координат: x<0, y>0");
else if (num=="3" || num.ToLower()=="iii")
Console.WriteLine("Возможные диапазоны координат: x<0, y<0");
else if (num=="4" || num.ToLower()=="iv")
Console.WriteLine("Возможные диапазоны координат: x>0, y<0");
else
Console.WriteLine("Такой четверти не существует!");