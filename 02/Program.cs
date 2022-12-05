// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
Console.Clear();


// -------------- TASK_32
// int size = 5;
// int lRange = -9;
// int rRange = 9;
// int[] array = new int[size];


// int[] FillArrayWithRandomNumbers(int size, int leftrange, int rightrange)
// {
//     Random rand = new Random();
//     int[] arr = new int[size];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(leftrange, rightrange + 1);
//     }

//     return arr;
// }

// array = FillArrayWithRandomNumbers(size, lRange, rRange);
// Console.WriteLine("[" + string.Join(",", array) + "]");

// int[] ChangePosNeg(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] *= -1;
//     }
//     return arr;
// }

// array = ChangePosNeg(array);
// Console.WriteLine("[" + string.Join(",", array) + "]");




// -------------- TASK_33

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

void FindNum(int[] arr, int value)
{
    int flag = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == value)
        {
            flag = 1;
            System.Console.WriteLine("Да!");
            break;
        }
    }
    if (flag == 0) System.Console.WriteLine("НЕТ!");
}

int size = 5;
int lRange = -9;
int rRange = 9;
int[] array = new int[size];

array = FillArrayWithRandomNumbers(size, lRange, rRange);
Console.WriteLine("[" + string.Join(",", array) + "]");
System.Console.WriteLine("Введите искомое в массиве число: ");
int num = int.Parse(Console.ReadLine());
FindNum(array, num);
