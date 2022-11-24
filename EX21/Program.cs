/*
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int getNumberFromUser(string massage)
{
int result = 0;
Console.WriteLine(massage);
result = Convert.ToInt32(Console.ReadLine());
return result;
}

int xA = getNumberFromUser("Введите X первой координаты=");
int yA = getNumberFromUser("Введите Y первой координаты=");
int zA = getNumberFromUser("Введите Z первой координаты=");
int xB = getNumberFromUser("Введите X второй координаты=");
int yB = getNumberFromUser("Введите Y второй координаты=");
int zB = getNumberFromUser("Введите Z второй координаты=");

double distanse(double xA, double yA, double zA, double xB, double yB, double zB)
{
   return Math.Sqrt(Math.Pow((xB-xA),2) + Math.Pow((yB - yA),2) + Math.Pow((zB - zA),2));
}

double Length =  distanse(xA, xB, yA, yB, zB, zA);
Console.WriteLine($"Расстояние в пространстве равно {Length}");
