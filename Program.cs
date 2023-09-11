using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Random generate = new Random();



        ///////////////////////////////
        //              1
        ///////////////////////////////



        //const int SIZE = 5;
        //int[] A = new int[SIZE];

        //for (int i = 0; i < SIZE; i++)
        //    A[i] = Int32.Parse(Console.ReadLine());

        //for (int i = 0; i < SIZE; i++)
        //    Console.Write(A[i] + " ");

        //Console.WriteLine();

        //int rowCount = 3;
        //int columnCount = 4;

        //double[,] B = new double[rowCount, columnCount];

        //for (int i = 0; i < rowCount; i++)
        //{
        //    for (int j = 0; j < columnCount; j++)
        //    {
        //        double randomValue = generate.NextDouble() * 10;
        //        B[i, j] = randomValue;
        //    }
        //}

        //for (int i = 0; i < rowCount; i++)
        //{
        //    for (int j = 0; j < columnCount; j++)
        //    {
        //        Console.Write(B[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //double maxElementB = B[0, 0];
        //double minB = B[0, 0];
        //double allElemtsSumB = 0;
        //double prozvedenieAllElementB = 1;

        //foreach (double element in B)
        //{
        //    if (element > maxElementB)
        //        maxElementB = element;

        //    if (element < minB)
        //        minB = element;

        //    allElemtsSumB += element;
        //    prozvedenieAllElementB *= element;
        //}

        //// Сумма четных элементов массива A
        //int sumEvenElementsA = 0;
        //foreach (int element in A)
        //{
        //    if (element % 2 == 0)
        //        sumEvenElementsA += element;
        //}

        //// Сумма нечетных столбцов массива B
        //double sumOddColumnsElementsB = 0;
        //for (int j = 0; j < B.GetLength(1); j++)
        //{
        //    if (j % 2 != 0)
        //    {
        //        for (int i = 0; i < B.GetLength(0); i++)
        //        {
        //            sumOddColumnsElementsB += B[i, j];
        //        }
        //    }
        //}

        //Console.WriteLine($"Максимальный элемент в массиве 'B' : {maxElementB}");
        //Console.WriteLine($"Минимальный элемент в массиве 'B' : {minB}");
        //Console.WriteLine($"Сумма всех элементов в массиве 'B' : {allElemtsSumB}");
        //Console.WriteLine($"Произведение всех элементов в массиве 'B' : {prozvedenieAllElementB}");
        //Console.WriteLine($"Сумма четных элементов в массиве 'A' : {sumEvenElementsA}");
        //Console.WriteLine($"Сумма нечетных столбцов в массиве 'B'  >> {sumOddColumnsElementsB}");



        ///////////////////////////////
        //              2
        ///////////////////////////////



        //int[,] array = new int[5, 5];
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {
        //        array[i, j] = generate.Next(-100, 101);
        //    }
        //}

        //int minElement = array[0, 0];
        //int maxElement = array[0, 0];
        //int minRow = 0, minCol = 0, maxRow = 0, maxCol = 0;

        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {
        //        if (array[i, j] < minElement)
        //        {
        //            minElement = array[i, j];
        //            minRow = i;
        //            minCol = j;
        //        }
        //        if (array[i, j] > maxElement)
        //        {
        //            maxElement = array[i, j];
        //            maxRow = i;
        //            maxCol = j;
        //        }
        //    }
        //}

        //int sum = 0;
        //bool betweenMinMax = false;

        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {
        //        if (i == Math.Min(minRow, maxRow) && j == Math.Min(minCol, maxCol))
        //        {
        //            betweenMinMax = true;
        //        }
        //        else if (i == Math.Max(minRow, maxRow) && j == Math.Max(minCol, maxCol))
        //        {
        //            betweenMinMax = false;
        //        }
        //        else if (betweenMinMax)
        //        {
        //            sum += array[i, j];
        //        }
        //    }
        //}

        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {
        //        Console.Write(array[i, j] + "  ");
        //    }
        //    Console.WriteLine();
        //}

        //Console.WriteLine("Минимальный элемент: " + minElement);
        //Console.WriteLine("Максимальный элемент: " + maxElement);
        //Console.WriteLine("Сумма элементов между минимальным и максимальным элементами: " + sum);



        ///////////////////////////////
        //              3
        ///////////////////////////////



        //string str = Console.ReadLine();
        //char[] chars = str.ToCharArray();
        //int step = 3;
        //Console.WriteLine($"Исходная строка : {str}");

        //for (var i = 0; +i < chars.Length; i++)
        //{
        //    chars[i] += (char)step;
        //}

        //Console.Write($"Зашифрованная строка шифром Цезарь : ");
        //foreach (char c in chars)
        //{
        //    Console.Write(c);
        //}

        //Console.WriteLine();
        //for (var i = 0; +i < chars.Length; i++)
        //{
        //    chars[i] -= (char)step;
        //}
        //Console.Write($"Расшифрованная строка шифра Цезарь : ");
        //foreach (char c in chars)
        //{
        //    Console.Write(c);
        //}



        ///////////////////////////////
        //              4
        ///////////////////////////////



        //int[] arr1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        //int[] arr2 = new int[10] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        //Sum(arr1, arr2);
        //multiplication(arr1, 3);
        //composition(arr1, arr2);

        //void Sum(int[] arr1, int[] arr2)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr1.Length; i++)
        //    {
        //        sum += arr1[i] + arr2[i];
        //    }

        //    Console.WriteLine(sum);
        //}

        //void multiplication(int[] arr, int number)
        //{
        //    int res = 0;
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    res = sum * number;
        //    Console.WriteLine(res);
        //}

        //void composition(int[] arr1, int[] arr2)
        //{
        //    int sum1 = 0;
        //    int sum2 = 0;
        //    for (int i = 0; i < arr1.Length; i++)
        //    {
        //        sum1 += arr1[i];
        //    }
        //    for (int j = 0; j < arr2.Length; j++)
        //    {
        //        sum2 += arr2[j];
        //    }
        //    int res = sum1 * sum2;
        //    Console.WriteLine($"SUMMA ARR1 = {sum1}");
        //    Console.WriteLine($"SUMMA ARR2 = {sum2}");
        //    Console.WriteLine($"ARR1 * ARR2 = {res}");
        //}
        //Console.WriteLine(res);



        ///////////////////////////////
        //              5
        ///////////////////////////////



        //Console.WriteLine("Введите арифметическое выражение (например, 2 + 3 - 1):");
        //string input = Console.ReadLine();

        //string[] parts = input.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);

        //if (parts.Length < 2)
        //{
        //    Console.WriteLine("Некорректное выражение. Должно быть как минимум два операнда.");
        //    return;
        //}

        //char[] operators = new char[parts.Length - 1];
        //for (int i = 0; i < operators.Length; i++)
        //{
        //    int operatorIndex = input.IndexOfAny(new char[] { '+', '-' });
        //    operators[i] = input[operatorIndex];
        //    input = input.Substring(operatorIndex + 1);
        //}

        //double result = double.Parse(parts[0]);

        //for (int i = 0; i < operators.Length; i++)
        //{
        //    double operand = double.Parse(parts[i + 1]);

        //    if (operators[i] == '+')
        //    {
        //        result += operand;
        //    }
        //    else if (operators[i] == '-')
        //    {
        //        result -= operand;
        //    }
        //}

        //Console.WriteLine("Результат: " + result);



        ///////////////////////////////
        //              6
        ///////////////////////////////



        //char lastChar = ' ';
        //string str = Console.ReadLine();
        //char[] c_str = str.ToCharArray();
        //int resistr = 32;

        //if (c_str[0] >= 97 && c_str[0] <= 122)
        //    c_str[0] -= (char)resistr;

        //for (int i = 0; i < c_str.Length; i++)
        //{
        //    if (c_str[i] == ' ')
        //        continue;
        //    else

        //        if ((lastChar == '.' || lastChar == '!' || lastChar == '?') && c_str[i] >= 97 && c_str[i] <= 122)
        //        c_str[i] -= (char)resistr;
        //    lastChar = c_str[i];

        //}

        //foreach (char c in c_str)
        //{
        //    Console.Write(c);
        //}



        ///////////////////////////////
        //              7
        ///////////////////////////////



        //string[] bannedWords = { "die", "sleep", "huy" }; // Замените на свои недопустимые слова
        //Console.WriteLine("Введите текст:");
        //string inputText = Console.ReadLine();

        //int countReplacements = 0;

        //StringBuilder resultText = new StringBuilder(inputText);
        //foreach (string bannedWord in bannedWords)
        //{
        //    int index = 0;
        //    while (index >= 0)
        //    {
        //        index = resultText.ToString().IndexOf(bannedWord, index, StringComparison.OrdinalIgnoreCase);
        //        if (index >= 0)
        //        {
        //            resultText.Replace(bannedWord, new string('*', bannedWord.Length), index, bannedWord.Length);
        //            countReplacements++;
        //            index += bannedWord.Length;
        //        }
        //    }
        //}

        //Console.WriteLine("Текст после обработки:");
        //Console.WriteLine(resultText);
        //Console.WriteLine($"Заменено {countReplacements} недопустимых слов.");
    }
}
