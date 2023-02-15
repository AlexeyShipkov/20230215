// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. Math.Min Math.Max не использовать
//[3.0 7.1 22.5 2.7 78.8] -> 76.1

double [] CreateNewArray (int size)  //метод создания нового случайного массива, размер указывает пользователь
{
    double [] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble()*100, 1); // массив вещественных чисел от 0 до 100, округленный до 1/10
    }
    return array; 
}

void ShowArray (double [] array)   //  метод вывода массива 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double DifArray (double [] array)  // метод поиска минимального, максимального чисел и их разности
{
    double dif = 0;
    double mmin = array[0];
    double mmax = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<mmin) mmin = array[i];
        if (array[i]>mmax) mmax = array[i];
    }
    dif = mmax - mmin;
    return Math.Round(dif,1);
}

Console.WriteLine("input array size");
int user_size = Convert.ToInt32(Console.ReadLine());

double [] newArray = CreateNewArray(user_size);
ShowArray(newArray);
Console.WriteLine($"In this random array the difference between max and min elements is  {DifArray(newArray)}");