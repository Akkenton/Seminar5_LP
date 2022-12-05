const int SIZE = 12;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;
int[] array = new int[SIZE];

int[] FillArrayWithRandomNumbers(int size, int leftrange, int rightrange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftrange, rightrange + 1);
    }

    return arr;
}

void SumPosAndNegNum(int[] arr, out int sumP, out int sumN)
{
    sumP = 0;
    sumN = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            sumP += arr[i];
        }
        else
        {
            sumN += arr[i];
        }
    }
}
array = FillArrayWithRandomNumbers(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine("[" + string.Join(",", array) + "]");


// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] < 0)
//     {
//         sumPositive += array[i];
//     }
//     else
//     {
//         sumNegative += array[i];
//     }
// }

// Console.WriteLine($"Сумма положительных элементов = {sumPositive}");
// Console.WriteLine($"Сумма отрицательны элементов = {sumNegative}");

SumPosAndNegNum(array, out int sumP, out int sumN);
System.Console.WriteLine($"Сумма положительных элементов = {sumP}, отрицательных элементов = {sumN}");