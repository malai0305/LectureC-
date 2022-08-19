//нахождение числа по индесу в массиве,функции.
int[] array = {13,45,8,70,94,93,7,49,41,78,39,50};
int n = array.Length;
int find =13;

int index = 0;
while (index<n)
{
    if(array[index]==find)
    {
       Console.WriteLine(index);

    }
    index++;
}