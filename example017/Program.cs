//Method1()- ничего не возвращает,ничего не принемает. 
void Method1()
{
    Console.WriteLine("Артём");

}
Method1();//-вызов metoda1()


//Method2()-ничего не возвращает,но принимает, какие-то аргументы.
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Привет Артём!!!");//- вызов Metoda2()

//Method21
 void Method21 (String msg,int count)
{
int i = 0;
while(i<count)
{
    Console.WriteLine(msg);
    i++;
}
}
Method21("Артём" ,4);
//Method3()- Что-то возвращает,но ни чего не принемает.
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Method4()-Что-то принимает,и что-то вщзвращает.

string Method4(int count,string text)
{
    int i = 0;
    string result = string.Empty;
    while(i<count)
    {
        result=result +text;
        i++;
    
    }
    return result;
}
string res=Method4(10,"z");
Console.WriteLine(res);