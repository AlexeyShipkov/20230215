//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int [] CreateNewArray (int size)  //метод создания нового случайного массива, размер указывает пользователь
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000); // массив только из трехзначных чисел
    }
    return array; 
}

void ShowArray (int [] array)   //  метод вывода массива 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int CountArray (int [] array)  // метод подсчета четных элементов в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)        
        count++;
    }
    return count;
}

Console.WriteLine("input array size");
int user_size = Convert.ToInt32(Console.ReadLine());

int [] newArray = CreateNewArray(user_size);
ShowArray(newArray);
Console.WriteLine($"In this random array the {CountArray(newArray)} elemens is multiples of two");