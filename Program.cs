// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array = { "Russia", "Finland", "UK", "Sweden", "USA" };
Console.WriteLine(string.Join(", ", array));
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        Console.Write($"{array[i]}, ");
    }
}

//string[] countries = { "Russia", "Finland", "UK", "Sweden", "USA" };
//Console.WriteLine(string.Join(", ", countries));
//var array = countries.Where(str => str.Length <= 3).ToArray();
//Console.WriteLine(string.Join(", ", array));
