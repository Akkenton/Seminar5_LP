int[] array = new int[5];
Random rand = new Random();
int sumPositive = 0;
int sumNegative = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}

Console.WriteLine("[" + string.Join(",", array) + "]");

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    {
        sumPositive += array[i];
    }
    else
    {
        sumNegative += array[i];
    }
}

Console.WriteLine($"Сумма положительных элементов = {sumPositive}");
Console.WriteLine($"Сумма отрицательны элементов = {sumNegative}");