// максимальное число.Метод функции.

int max (int arg1,int arg2,int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 100;
int a2 = 3;
int a3 = 33;
int b1 = 200;
int b2 = 77;
int b3 = 87;
int c1 = 23;
int c2 = 500;
int c3 = 7;

int result = max(max(a1,b1,c1),max(a2,b2,c2),max(a3,b3,c3));

Console.WriteLine (result );
