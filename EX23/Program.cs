/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125  
*/
int userNumber = new int();
Console.WriteLine("Введите число");
userNumber = Convert.ToInt32(Console.ReadLine());
int Squares = 1;
while (Squares <= userNumber)
{
    Console.WriteLine(Math.Pow(Squares,3));
    Squares++;
}