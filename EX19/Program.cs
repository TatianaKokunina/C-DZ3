/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да  pal = pal * 10 + number % 10; number /= 10
*/

int userNumber = new int();
Console.WriteLine("Введите пятизначное число");
userNumber = Convert.ToInt32(Console.ReadLine());
int pal = 0;

while(userNumber > 0)
    {
    pal = pal * 10 + (userNumber % 10);
    userNumber /= 10;
    }
if(pal == userNumber)
   {
    Console.WriteLine("Это палиндром!");
   }
else
    {
    Console.WriteLine("Это не палиндром!");
    }