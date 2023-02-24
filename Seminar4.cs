// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Enter number A");

int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number B");

int numB = int.Parse(Console.ReadLine());

if (numB < 1)
{
    Console.WriteLine("Number B less then 1");
}
else
{
    int result = GetPower(numA, numB);
    Console.WriteLine ($"А в степени В = {result}");
    
}

int GetPower(int num, int stepen)
{
 int res = 1; 

for (int i = 0; i < stepen; i++)
{
    res*=num;
}
return res;
}

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Enter number");

int Number = int.Parse(Console.ReadLine());

if (Number < 0)
{
    Console.WriteLine("Number B less then 0");
}
else
{
    int result = GetSum(Number);
    Console.WriteLine ($"Сумма цифр = {result}");
    
}

int GetSum(int num)
{
 int sum = 0;

while (num >0)
{
sum += num%10;
num = num/10;
}

return sum;

}
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

Console.WriteLine("Enter size:");
string strsize = Console.ReadLine();
int size = Convert.ToInt32(strsize);

Console.WriteLine("Enter min value:");
string strminValue = Console.ReadLine();
int minValue = Convert.ToInt32(strminValue);

Console.WriteLine("Enter max value:");
string strmaxValue = Console.ReadLine();
int maxValue = Convert.ToInt32(strmaxValue);

int[]Array = GetRandomArray(size, minValue, maxValue);

Console.WriteLine($"[{String.Join(", ",Array)}]");

int[] GetRandomArray (int size, int minValue, int maxValue)
{
int[] result = new int [size];
 for (int i=0; i<size; i++)

{
result[i] = new Random().Next(minValue, maxValue);
}
return result;
}

