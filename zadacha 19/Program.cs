// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Ведите первое число: ");
int namberX = Convert.ToInt32(Console.ReadLine());
int namber = 0;
int namber1 =0;
int namber2 =0;
int namber3 =0;

namber = namberX/10000;
namber1 = namberX/1000;
namber1 = namber1%10; 
namber2 = namberX%100;
namber2 = namber2/10;
namber3 = namberX %10;


if(namber1 == namber2 && namber == namber3)
{
    Console.Write("да");
}
else
{
    Console.Write("нет");
}