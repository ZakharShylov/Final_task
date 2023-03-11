// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Пример:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


Console.Clear();

int SelectionArray(string[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3) count++;
    }
    return count;
}

string[] FillFinalArray(string[] Array, int count)
{
string[] result = new string[count];
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length <= 3)
    {
        result[result.Length - count] = Array[i];
            count--;
    }
}
return result;
}

string[] Array = {"hello", "2", "world", ":-)", "77"};
Console.Write($"[{string.Join(", ", Array)}]");
Console.Write("  ->  ");
int Selection = SelectionArray(Array);
string[] FinalArray = FillFinalArray(Array,Selection);
Console.Write($"[{string.Join(", ", FinalArray)}]");