// Написать программу, которая из имеющего массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void CreateNewArray(string[] array)
{    
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input {i + 1} element of array: ");
        string temp = new string(Console.ReadLine());
        if (String.IsNullOrWhiteSpace(temp))
        {
            Console.WriteLine("Value is empty or null, please, re-input");
            i -= 1;
        }
        else array[i] = temp;
    }
}