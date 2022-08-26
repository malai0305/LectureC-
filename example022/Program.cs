//==== Работа с текстом.
// Дан текст.В тексте нужно все пробелы заменить чертачками,
// аленькие буквы "к" заменить большими "К",
// а большие "С" заменить на маленькие "с".

// Ясна ли задача ?

string text = "-Я думаю,- сказал князь, улыбаясь,- что,"
+"ежели бы вас послали вместо нашего милого Винцегероде,"
+"вы бы взяли приступом согласие прусского короля."
+"Вы так Красноречивы.Вы дадите мне чаю?";

//string s = "qwerty"
// s[3] 

string Replace( string text,char oldValue,char newValue)
{
    string result=string.Empty;//-инициализация пустой строки
    int Length=text.Length;
    for(int i=0;i<Length;i++)
    {
        if(text[i]==oldValue)result=result+$"{newValue}";
        else result=result+$"{text[i]}";
    }
    return result;
}
string newText=Replace(text,' ','|');
Console.WriteLine(newText);
Console.WriteLine();
newText=Replace(text,'к','К');
Console.WriteLine(newText);
Console.WriteLine();
newText=Replace(text,'с','С');
Console.WriteLine(newText);