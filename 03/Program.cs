// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21





// Задача №35 -------------------

// int[] FillArrayWithRandomNumbers(int size, int leftrange, int rightrange)
// {
//     Console.Clear();
//     Random rand = new Random();
//     int[] arr = new int[size];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(leftrange, rightrange + 1);
//     }

//     return arr;
// }

// int FindCol(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if ((arr[i] >= 10) && (arr[i] <= 99))
//         {
//             count++;
//         }
//     }
//     return count;
// }

// // ----------------------------------------------------


// int size = 123;
// int lRange = -100;
// int rRange = 100;


// int[] array = new int[size];

// array = FillArrayWithRandomNumbers(size, lRange, rRange);
// // Console.WriteLine("[" + string.Join(",", array) + "]");
// Console.WriteLine($"Количество цифр заданого периода в массиве: {FindCol(array)}");


// // Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// // [1 2 3 4 5] -> 5 8 3
// // [6 7 3 6] -> 36 21


int[] FillArrayWithRandomNumbers(int size, int leftrange, int rightrange)
{
    Console.Clear();
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftrange, rightrange + 1);
    }

    return arr;
}


int[] FillNewArray(int[] arr)
{
    int[] arrayNew = new int[(arr.Length / 2) + (arr.Length % 2)];
    if (arr.Length % 2 == 0)
    {
        for (int i = 0; i < (arr.Length / 2); i++)
        {
            arrayNew[i] = arr[i] * arr[(arr.Length - 1) - i];
        }
    }
    else
    {
        for (int i = 0; i < (arr.Length / 2); i++)
        {
            arrayNew[i] = arr[i] * arr[(arr.Length - 1) - i];
        }
        arrayNew[arrayNew.Length - 1] = arr[arr.Length / 2];

    }


    return arrayNew;
}

// // -----------------------------------------------------

int size = 5;
int lRange = 0;
int rRange = 10;

int[] array = new int[size];
array = FillArrayWithRandomNumbers(size, lRange, rRange);

Console.WriteLine("Заданый массив: [" + string.Join(",", array) + "]");
Console.WriteLine("Новый массив: [" + string.Join(",", FillNewArray(array)) + "]");