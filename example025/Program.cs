int[,]pic=new int[23,25];
void PrintImage(int[,]Image)
{
    for(int i=0;i<Image.GetLength(0);i++)
    {
        for(int j=0;j<Image.GetLength(1);j++)
        {
            if(Image[i,j]==0)Console.Write($" ");
            else Console.Write($"+");

        }
        Console.WriteLine();
    }
}
PrintImage(pic);
void FillImage(int row,int col)
{
    if(pic[row,col]==0)
    {
        pic[row,col]=1;
        FillImage(row - 1,col);
        FillImage(row,col - 1);
        FillImage(row + 1,col);
        FillImage(row,col + 1);
    }
}
PrintImage(pic);
FillImage(13, 13);
PrintImage(pic); 