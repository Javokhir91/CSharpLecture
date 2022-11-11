int number = new Random().Next(10,1000);
int FindDigit(int num)
{
    num = new Random().Next(10, 1000);
    Console.WriteLine(number);
    int result = number % 10;
    result = result / 1;
    return result;
    
}

Console.WriteLine(FindDigit(number));







// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
// int number = new Random().Next(100,1000);
// int FindDigit(int number)
// {
//     number = new Random().Next(100, 1000);
//     Console.WriteLine(number);
//     int result = number % 100;
//     result = result / 10;
//     return result;
// }
// Console.WriteLine(FindDigit(number));



// Console.Write("Введите ваше имя : ");
// string username = Console.ReadLine();
// Console.Write("Привет , " + username);
// //Console.Write(username);

