// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintArray3Dim(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
    }
}
int[] Mixing(int[] array, int length, int stepOfMix)
{
    int temp = -1;
    for (int i = 0; i < stepOfMix; i++)
    {
        int index1 = new Random().Next(0, length);
        int index2 = new Random().Next(0, length);
        //Console.WriteLine($"stepofmix {i}  index1 {index1}  index2 {index2}");// это тест
        temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
    return array;
}

Console.Clear();
int rowArray = new Random().Next(2, 4);
int columnArray = new Random().Next(2, 4);
int thirdArray = new Random().Next(2, 4);
int[,,] someArray = new int[rowArray, columnArray, thirdArray];

//Создаем неповторяемые значения в одномерном массиве и перемешиваем
int lengthArrayFR = rowArray * columnArray * thirdArray;
//Console.Write($"{rowArray}  {columnArray}  {thirdArray}  {lengthArrayFR}");// это тест
int[] arrayForRandom = new int[lengthArrayFR];
for (int i = 0; i < lengthArrayFR; i++)
{
    arrayForRandom[i] = i + 10;
    //Console.Write($"{arrayForRandom[i]}  ");// это тест
}
Mixing(arrayForRandom, lengthArrayFR, 1000);

//Записываем значения в три-массив
int step = 0;
for (int i = 0; i < rowArray; i++)
{
    for (int j = 0; j < columnArray; j++)
    {
        for (int k = 0; k < thirdArray; k++)
        {
            someArray[i, j, k] = arrayForRandom[step];
            step++;
        }
    }
}
Console.WriteLine($"Три-массив {rowArray}x{columnArray}x{thirdArray} с дву-значениями:");
PrintArray3Dim(someArray);