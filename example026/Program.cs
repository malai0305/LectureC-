//Вычисления факториала ,при помощи рекурсии.

double Factorial(int n)
{
    //1i=1
    //0i=1
    if(n==1)return 1;
    else return n*Factorial(n-1);
}
Console.WriteLine(Factorial(3));
for (int i=1;i<40;i++)
{
    Console.WriteLine($"{i}i={Factorial(i)}");
}