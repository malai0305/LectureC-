﻿// новый цикл for ,не только while.

for(int i = 0;i<10;i++)
{
    Console.WriteLine(i);
}

//Цикл в цикле.
for(int i =0;i<10;i++)
{
    for (int j=0;j<10;j++)
    {
        Console.WriteLine(i*j);
    } 
    Console.WriteLine();
}
//Вывод таблицы умножения на экран.

for(int i = 2;i<=10;i++)
{
    for(int j = 2;j<=10;j++)
    {
        Console.WriteLine($"{i}*{j}={i*j}");
    }
    Console.WriteLine();
}
//
