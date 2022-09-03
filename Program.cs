// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateArray3DimRandom(int row, int column, int third, int maxEl)
{
    int[,,] array = new int[row, column, third];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < third; k++)
            {
                array[i, j, k] = new Random().Next(10, maxEl);
            }
        }
    }
    return array;
}
void PrintArray3Dim(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j}, {k})  ");
            }
        }
        //Console.WriteLine();
    }
}

Console.Clear();
int rowArray = new Random().Next(4, 8);
int columnArray = new Random().Next(4, 8);
int thirdArray = new Random().Next(4, 8);
int[,,] someArray = CreateArray3DimRandom(rowArray, columnArray, thirdArray, 100);

Console.WriteLine($"Три-массив {rowArray}x{columnArray}x{thirdArray} с дву-значениями:");
PrintArray3Dim(someArray);