// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

 /*using System;
 
class Program
 {
 public static int Main() 
 {
  while (true)
  {
    Console.Write("Введите число или 'q' для выхода: ");
    string input = Console.ReadLine();
      if (input == "q");
  }
  {
    break;
  }
   }
 

 int number;
 if(int.TryParse(input,out number))
 {
    int sum = 0;
    while (number > 0)
 {
    sum += number % 10;
    number/= 10;
 }   
 if (sum % 2 == 0)
 {
    Console.WriteLine("[STOP]");
    break;
 }
 } */
 
 
// Подсчет количества четных чисел в массиве !!ЗАДАЧА 2!!
/*
using System;
class Program
{
static void Main()
{
int[] array = new int[10]; 
Random rnd = new Random(); 
int elementCount = 0; 

for (int i = 0; i < array.Length; i++)
{
array[i] = rnd.Next(100, 1000); 
Console.Write(array[i] + " "); 

if (array[i] % 2 == 0)
{
elementCount++;
}
}

Console.WriteLine($"\nКоличество четных чисел в массиве: {elementCount}");
}
}
*/
 

 //Реверсирование одномерного массива !!ЗАДАЧА 3!!
 /*
 using System;
class Program
{
static void Main()
{
int[] numbers = {1, 3, 5, 6, 7, 8}; 
int temp;

Console.Write("Исходный массив: ");
foreach (int number in numbers)
{
Console.Write(number + " ");
}

for (int i = 0; i < numbers.Length / 2; i++)
{

temp = numbers[i];
numbers[i] = numbers[numbers.Length - 1 - i];
numbers[numbers.Length - 1 - i] = temp;
}

Console.Write("\nПеревернутый массив: ");
foreach (int number in numbers)
{
Console.Write(number + " ");
}
}
}
*/