// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] numbers = { 3, 9, 5, 14, 2, 11 };
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 7)
    {
        sum += numbers[i];
    }
}
Console.WriteLine(sum);

for (int i = 3; i<19; i += 3)
{
    Console.Write(i);
    if (i < 18 ) Console.Write(" , ");
}


