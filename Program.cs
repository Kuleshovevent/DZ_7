void Zadacha47()
{
    /* Задача 47: Задайте двумерный массив размером m×n,
    заполненный случайными вещественными числами,
    округлёнными до одного знака */
    int rows = 4;
    int columns = 6;
    double [,] numbers = new double[ rows, columns];

    Random rand = new Random();

    //Заполнение массива
    rows = numbers.GetLength(0);
    columns = numbers.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i,j] = Math.Round(rand.NextDouble()*5,1);
        }
    }

    Console.WriteLine("Массив с вещественными числами:");
    Console.WriteLine(" ");

    //Печать массива
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{numbers[i,j]}\t");
        }
        Console.WriteLine(); 
    }
}

void Zadacha50()
{
    /*     Задача 50: Напишите программу, которая на вход
    принимает индексы элемента в двумерном массиве, и
    возвращает значение этого элемента или же указание,
    что такого элемента нет. */
    
    int rows = 4;
    int columns = 4;

    int [,] numbers = new int [rows, columns];

    FillArray(numbers,5,20);
    PrintArray(numbers);

    Console.WriteLine("Задан массив ");
    Console.WriteLine(" ");
    Console.WriteLine("Введите значение индексов элемента, который вам нужен");
    Console.WriteLine(" ");
    Console.WriteLine("Введите значение индекса строки");
    int r = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение индекса столбца");
    int c = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if(i==r && j==c)
            {
                Console.WriteLine($"Ваше число =  {numbers[i,j]}");
            }
        }
    }
    
    if(r < 0 | r > rows | c < 0 | c > columns)
    {
        Console.WriteLine("Таких индексов не существует");
    }  
    
}

void Zadacha52()
{
    /* Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце. */
    int rows = 4;
    int columns = 4;

    int [,] numbers = new int [rows, columns];

    FillArray(numbers,0,5);
    PrintArray(numbers);

    for (int i = 0; i < rows; i++)
    {   
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum = sum + numbers[j,i];
            Console.Write(numbers[j,i] + " ");
        }
        double a = Math.Pow(sum/rows,2);
        int n = i+1;
        Console.WriteLine("Среднее арифметическое " +n+" колонки равно " + a);
    }


}

void FillArray(int [,] numbers, int MinValue, int MaxValue)
{
    MaxValue++;
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i,j] = rand.Next(MinValue,MaxValue);
        }
    }
}

void PrintArray(int [,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{numbers[i,j]}\t");
        }
        Console.WriteLine();   
    }

}

//Zadacha47();
//Zadacha50();
Zadacha52();

