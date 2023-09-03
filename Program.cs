//задайте масссив из М элементов заполненый случайными числами в заданном промежутке от а до б. 
//Найдите сумму отрицательных элементов массива.
/*
int[] CreateRandomArray(int size, int max, int min)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);

    }
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumNegotives(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        {
          sum += array[i];
        } 
        
    }
    return sum;
}

Console.Write("введите размер массива: ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите максимальное значение массива: ");
int max1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите минимальное значение массива: ");
int min1 = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size1, max1, min1);
WriteArray(myArray);
Console.WriteLine(SumNegotives(myArray));
*/

//напишите программу которая будет заменять элементы массива : положительные элемеенты на отрицательные и наоборот
/*
int[] CreatRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] replacement(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

Console.Write("введите размер массива: ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите мин значение: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите макс значение: ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatRandomArray(size1, min1, max1);
WriteArray(myArray);
int[] myArray1 = replacement(myArray);
WriteArray(myArray1);
*/
// напишиете программуу которая будет проверять есть ли в массиве заданное число
/*
int[] CreatRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
bool SpecifiedNumberIsPresent(int[] array, int number)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == number)
        return true;
    }
    return false;
}

Console.Write("введите размер массива: ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите мин значение: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите макс значение: ");
int max1 = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreatRandomArray(size1, min1, max1);
WriteArray(myArray);
Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool num1 = SpecifiedNumberIsPresent(myArray, num);
Console.WriteLine(num1);
*/
// напишите программу которая посчитаем количество элементов входящих в массие в заданоом приделе от а до б.
/*
int[] CreatRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int NumberOfElements(int[] array, int MinElements,int MaxElements)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= MinElements && array[i] <= MaxElements) count ++;
    }
    return count;

}

Console.Write("введите размер массива: ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите мин значение: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите макс значение: ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatRandomArray(size1, min1, max1);
WriteArray(myArray);

Console.Write("введите мин значение искомого числа : ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите макс значение искомого числа: ");
int max2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(NumberOfElements(myArray, min2, max2));
*/
//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве. 
/*
int[] CreatRandomArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
    
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int CountEvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2==0)
        {
            count++;
        }
    }
    return count;
}


Console.Write("введите размер массива: ");
int size1 = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatRandomArray(size1);
WriteArray(myArray);
Console.WriteLine(CountEvenNumbers(myArray));
*/
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreatRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int Sum(int[] array)
{
    int sum1 = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2==1)
        {
            sum1 += array[i];
        }

    }
    return sum1;
}




Console.Write("введите размер массива: ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите мин значение: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите макс значение: ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatRandomArray(size1, min1, max1);
WriteArray(myArray);

Console.WriteLine(Sum(myArray));
*/
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] CreatRandomArray(int size)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        //array[i] = Convert.ToDouble(new Random().NextDouble()); //генерирует от 0 до 1
    }
    return array;
}

void WriteArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)   
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double MinMax(double[] array)
{
    double sum3 = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
         if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
    }
    sum3 = max - min;
    Console.WriteLine($"{max} - {min}  ");
    return sum3;
    
    
}


Console.Write("введите размер массива: ");
int size1 = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreatRandomArray(size1);
WriteArray(myArray);
Console.Write(MinMax(myArray));


