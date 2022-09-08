/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых 
меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении обходимся исключительно массивами
*/

void PrintArray(string[] arr)
{
    for (int i = 0; i <arr.Length; i++)
       Console.Write($" {arr[i]},  ");
}

int CountLengthNewMass(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            count += 1;
    }
    return count;
}

string[] FillNewArray(string[] arr, int count)
{
    int k = 0;
    string[] newArray = new string[count];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArray[k] = arr[i];
            k += 1;
        }
    }
  return newArray;
}

Console.Write("Enter some symboles devided by space: ");
string s = Console.ReadLine();
string[] arr = s.Split(' ');

CountLengthNewMass(arr);
string[] newArr = FillNewArray(arr, CountLengthNewMass(arr));
PrintArray(newArr);