using System;
using System;

namespace Laba5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 7;
            int[,] matrix = new int[size, size];
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rand.Next(101);
                }
            }

            Console.WriteLine("Початкова матриця:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[size - 1 - j, size - 1 - i];
                    matrix[size - 1 - j, size - 1 - i] = temp;
                }
            }
            
            Console.WriteLine("Матриця після симетричного відображення відносно побічної діагоналі:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        //task 2
        static void Main()
        {
            int N = 30;
            int[] array = new int[N];
            Random rand = new Random();

            for (int i = 0; i < N; i++)
            {
                array[i] = rand.Next(-10, 11);
            }

            Console.WriteLine("Початковий масив:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            int zeroIndex = Array.IndexOf(array, 0);

            if (zeroIndex > 0)
            {
                BubbleSort(array, 0, zeroIndex - 1);
            }

            Console.WriteLine("Перетворений масив:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void BubbleSort(int[] array, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j < end - (i - start); j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

        }
    }
}








//// Оголошення двовимірного масиву
//int[,] myMatrix = new int[2, 3];

//// Оголошення змінної для генерації випадкових чисел
//Random rand1 = new Random();

//// Заповнення двовимірного масиву випадковими значеннями
//for (int i = 0; i < myMatrix.GetLength(0); i++)
//{
//    for (int j = 0; j < myMatrix.GetLength(1); j++)
//    {
//        myMatrix[i, j] = rand1.Next(100); // Генерує випадкове число від 0 до 99
//    }
//}

//// Виведення елементів масиву та обчислення суми
//int sum = 0;
//Console.WriteLine("Елементи масиву:");
//for (int i = 0; i < myMatrix.GetLength(0); i++)
//{
//    for (int j = 0; j < myMatrix.GetLength(1); j++)
//    {
//        Console.Write(myMatrix[i, j] + "\t"); // Виведення елемента масиву
//        sum += myMatrix[i, j];               // Додавання елемента до суми



//int[,] myMatrix = new int[2, 3];
//for (int i = 0; i < myMatrix.GetLength(0); i++)
//{
//    for (int j = 0; j < myMatrix.GetLength(1); j++)
//    {
//        Console.WriteLine("введіть елемент масиву [{0},{1}]", i, j);
//        myMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
//    }
//}



//    int[,] array = {
//    { 4, 10, 5 },
//    { 3, 2, 35 },
//    { 30, 55, 66 }
//};
//    int a = 5;

//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            array[i, j] = a.Next(-99, 99);
//            Console.WriteLine($"{i},{j}: " + array[i, j]);
//        }
//    }
//    int sum = 0;

//    for (int i = 0; i < array.GetLength(2); i++)
//    {
//        int min = array[i, 0];
//        for (int j = 0; j < array.GetLength(3); j++)
//            if (array[i, j] < min)
//            {
//                min = array[i, j];
//            }
//    }
//    Console.WriteLine("sum" + sum);



