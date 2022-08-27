//Двумерные массивы 

//string[,]table=new string[2,5];
// string.Empty- инициализация пустой строки.
//table[0,0][0,1][0,2][0,3]
//table[1,0][1,1][1,2][1,3]
//table[1,2]="слово";
//for(int rows=0;rows<2;rows++)
//{
    //for(int columns=0;columns<5;columns++)
    //{
        //Console.WriteLine($"-{table[rows, columns]}-");
    //}
//}
void PrintArray(int[,]matrix)
{
for(int i=0;i<matrix.GetLength(0);i++)
{
    for(int j=0;j<matrix.GetLength(1);j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
Console.WriteLine();
}
}
int[,] matrix=new int[3,4];
PrintArray(matrix);
void FillArray(int[,]matr)
{
    for(int i=0;i<matr.GetLength(0);i++)
    {
        for(int j=0;j<matr.GetLength(0);j++)
        {
            matr[i,j]=new Random().Next(1,10);
        }
    }
}
int[,]matr=new int[3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
