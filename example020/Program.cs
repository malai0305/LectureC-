// Сортировка методом выбора.Цикл в цикле.

void SelectionSort (int[]array)
{
    for(int i = 0;i<array.Lendyh-1;i++)
    {
        int Position = i;
        for(int j =i+1;j<array.Length;j++)
        {
            if(array[j]<array[minPosition])
            {
                minPosition = j;
            }
        }

int temporary = Array[i];
Array[i] = Array[minPosition];
array[minPosition] = temporary;
    }
}