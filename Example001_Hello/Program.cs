// int number = new Random().Next(100,1000);
// Console.WriteLine(number);
// int FindDigit(int number)
// {
//     number = new Random().Next(100, 1000);
//     int result = number % 100;
//     result = result / 10;
//     return result;
// }
// Console.WriteLine(FindDigit(number));


// Console.WriteLine(number);

Console.WriteLine("Введите трехзначное число: ");
int nums = new Random().Next(10, 1000);
Console.WriteLine(nums);
if (nums >= 10)
{
    // int res = nums / 10;
    // Console.WriteLine($"первый ИФ_1 цифра числа {nums} - {res}");
    int res1 = nums % 10;
    Console.WriteLine($"Вторая цифра числа {nums} - {res1}");
}

else
{
    Console.WriteLine("1третьей цифры нет");
}
if (nums > 100 & nums < 1000)
{
    // int res = nums / 10;
    // Console.WriteLine($"!!!!! ИФ_2 цифра числа {nums} - {res}");
    int res1 = nums % 10;
    Console.WriteLine($"третье цифра числа {nums} - {res1}");
}
