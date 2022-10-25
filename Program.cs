//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
/*
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, colums, -100, 100);
PrintArray(array);

double[,] GetArray(int m, int n, int minValue, int maxValue){
    double[,] array = new double[m, n];
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i, j] = Convert.ToDouble
                            (new Random().Next(minValue, maxValue)/10.0);
        }
    }
    return array;
}

void PrintArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
    Console.WriteLine();
    }
}
*/

//Задача 50. Напишите программу, которая на вход 
//принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
/*
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, colums, -10, 10);
PrintArray(array);

Console.Write("Введите позицию элемента в массиве: ");
int I = int.Parse(Console.ReadLine()!);
int J = int.Parse(Console.ReadLine()!);

Element(array, I, J);

void Element(int[,] array, int row, int colum){
    int res = 0;
    if((row < array.GetLength(0) && row >= 0) && 
                            (colum < array.GetLength(1) && colum >= 0)){
        res = array[row, colum];
        Console.WriteLine($"Значение с индексами {row}, {colum} = {res}");
    } else{
        Console.WriteLine("Введены неверные индексы");
    }
}
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] array = new int[m, n];
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
    Console.WriteLine();
    }
}
*/

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
/*
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, colums, -10, 10);
PrintArray(array);
Console.WriteLine();

double[] arifmArray = ArifmMas(array, colums);
Console.WriteLine("Массив из средних арифметических " + 
                  "элементов в каждом столбце: ");
PrintArray1(arifmArray);

double [] ArifmMas(int[,] mas, int n){
     double res = 0;
    double[] array = new double[n];
    for(int j = 0; j < mas.GetLength(1); j++){
        for(int i = 0; i < mas.GetLength(0); i++){
            res += Convert.ToDouble(mas[i,j])/Convert.ToDouble(n); 
        }
        array[j] += res;
        res = 0;  
    }
    return array;
}
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] array = new int[m, n];
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
    Console.WriteLine();
    }
}

void PrintArray1(double[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i]+ " ");
    }
}
*/

//Задача 60. Сформируйте трёхмерный массив из неповторяющихся 
//двузначных чисел. Напишите программу, которая будет построчно 
//выводить массив, добавляя индексы каждого элемента.
/*
int[,,] res = GetArray(10,20);
PrintArray(res);

int[,,] GetArray(int minValue, int maxValue){
    int[,,] array = new int[2,2,2];
    int[] mas = new int[8];
    int res = 0;

    for (int i = 0; i < mas.Length; i++){
        mas[i] = new Random().Next(minValue, maxValue);
        if (i > 0){
            for (int j = 0; j < i; j++){
                while (mas[i] == mas[j]){
                    mas[i] = new Random().Next(minValue, maxValue);
                    j = 0;
                }
            }
        }
    }

   for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(2); k++){
                array[i, j, k] = mas[res];
                res++;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(2); k++){
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows);
PrintArray(array);

int[,] GetArray(int m){
    int[,] array = new int[m, m];
    int i = 0;
    int j = 0;
    int peremen = 1;
    while ( peremen <= Math.Pow(m,2)){
        array[i, j] = peremen;
        peremen ++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1) j++;
        else if (i < j && i + j >= array.GetLength(0) - 1) i++;
        else if (i >= j && i + j > array.GetLength(1) - 1) j--;
        else i--;
    }
    return array;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if (array[i, j] < 10) Console.Write("0"+array[i,j]+ " ");
            else Console.Write(array[i,j]+ " ");
        }
    Console.WriteLine();
    }
}
*/