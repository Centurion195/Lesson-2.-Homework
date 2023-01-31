// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Введите координаты точек:");
Console.WriteLine("Точка №1");
Console.Write("x = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("y = ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("z = ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Точка №2");
Console.Write("x = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("y = ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("z = ");
int z2 = int.Parse(Console.ReadLine());

double l1 = Convert.ToDouble((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
double len = Math.Sqrt(l1);

string graph = "3D";
if ((x1==0 && x2==0) || (y1==0 && y2==0) || (z1==0 && z2==0)) graph = "2D";
if (((x1==0 && x2==0) && (y1==0 && y2==0)) || ((y1==0 && y2==0) && (z1==0 && z2==0)) || ((x1==0 && x2==0) && (z1==0 && z2==0))) graph = "1D";

Console.WriteLine($"Расстояние между точками в {graph} пространстве: {len}");