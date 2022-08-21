﻿//сортировка методом выбора.

 int []arr={1,2,6,7,4,8,5,9,3,7,4,5,8};
 void PrintArray(int[]array)
 {
    int count = array.Length;
    for(int i = 0;i<count;i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
 }
 void SelectionSort(int[]array)
 {
    for(int i=0;i<array.Length-1;i++)
    {
        int minPosition = i;
        for(int j = i+1;j<array.Length;j++)
        {
            if(array[j]<array[minPosition])minPosition = j;
        }
        int temporary = array[i];
        array[i]=array[minPosition];
        array[minPosition]=temporary;
    }
 }
 PrintArray(arr);
 SelectionSort(arr);
PrintArray(arr);