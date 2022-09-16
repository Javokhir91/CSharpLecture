int a = 1;
int b = 8;
int c = 3;
int d = 2;
int e = 6;

int max = a;

if (b > max) max = a;
if (c > max) max = b;
if (d > max) max = d;
if (e > max) max = e;

Console.WriteLine("максимальное число : " + max);
