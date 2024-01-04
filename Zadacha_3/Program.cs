// Задайте произвольный массив. Выведете его элементы, начиная с конца.
//  Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int [] array = {1,45,76,44,98};
PrintArrayReversedFrom (array, array.Length-1);

void PrintArrayReversedFrom (int [] arr, int index)
{
    if(index < 0)
    {
        return;
    }
    System.Console.WriteLine (arr [index]);
    PrintArrayReversedFrom (arr, index-1);

}