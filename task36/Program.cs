// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int [] CreateNewArray (int size)  //метод создания нового случайного массива, размер указывает пользователь
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 101); // массив из любых чисел от -100 до 100
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

int SumArray (int [] array)  // метод подсчета суммы элементов массива на нечетных местах
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

Console.WriteLine("input array size");
int user_size = Convert.ToInt32(Console.ReadLine());

int [] newArray = CreateNewArray(user_size);
ShowArray(newArray);
Console.WriteLine($"In this random array the sum of odd-position elements is {SumArray(newArray)}");