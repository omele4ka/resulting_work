// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:

// ["hello", "2", "world", ":-)"] -> ["2", ":-"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"1-> []

Console.WriteLine("Сколько строк вы хотите ввести?");
int num_strings = Convert.ToInt32(Console.ReadLine());

string[] initialArray = new string[num_strings];
FillStingsArr(initialArray);

Console.Write("[" + string.Join(", ", initialArray) + "]");
Console.WriteLine();

int maxLength = 3;
int ResultArrayLength = CountResultArrayLenght(initialArray, maxLength);
Console.WriteLine(ResultArrayLength);

if (ResultArrayLength == 0) Console.WriteLine("[]");

else 
{
    string[] newArray = new string[ResultArrayLength];
    FillResultStringArray(initialArray, newArray, maxLength);
    Console.Write("[" + string.Join(", ", newArray) + "]");
    Console.WriteLine();
}

void FillStingsArr(string[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i + 1}. Введите строку ");
        array[i] = Console.ReadLine();
    }
}

int CountResultArrayLenght(string[] arr, int numLenght)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= numLenght) counter++;
    }
    return counter;
}

void FillResultStringArray(string[] arrayOld, string[] arrayNew, int numStringLen)
{
    int newArrayIndex = 0;
    for (int i = 0; i < arrayOld.Length; i++)
    {
        if (arrayOld[i].Length <= numStringLen)
        {
            arrayNew[newArrayIndex] = arrayOld[i];
            newArrayIndex++;
        }
    }
}