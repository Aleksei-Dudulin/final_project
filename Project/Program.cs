// Написать программу, которая из имеющего массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void CreateArray(string[] array)
{    
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input {i + 1} element of array: ");
        string temp = new string(Console.ReadLine());
        if(String.IsNullOrWhiteSpace(temp))
        {
            Console.WriteLine("Value is empty or null, please, re-input");
            i -= 1;
        }
        else array[i] = temp;
    }
}

void ShowArray(string[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
        if(i == (array.Length - 1))
            Console.Write($"\"{array[i]}\"");
        else
            Console.Write($"\"{array[i]}\", ");
    Console.WriteLine("]");
}

string[] CreateNewArray(string[] array)
{
    int count = 0;
    string[] newArray = new string[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) 
        {
            newArray[count]= array[i];
            count++;
        }
    }
    if(array.Length != count)    
        Array.Resize(ref newArray, count);
    return newArray;
}

Console.Write("Input quantity strings of array: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if(n<0) n*=(-1);
string[] myArray = new string[n];
CreateArray(myArray);
Console.Write("Initial array: ");
ShowArray(myArray);
Console.Write("Modified array: ");
ShowArray(CreateNewArray(myArray));