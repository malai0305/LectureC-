//=====Работа с текстом
//Дан текст.В тесте все пробелы нужно заменить на черточки.
//Маленькие буквы "к" замениь на большие "К".
//Большие "С" заменить на маленькие "с".

string text = " - Я думаю , - сказал князь , улыбаясь ,- что,"
+" ежели бы вас послали вместо нашего милого Винценгероде ,"
+" вы бы взяли приступом согласие прусского короля ."
+" Вы так красноречивы . Вы дадите мне чаю ? ";
// string s = "qwerty"
// s[3]//r
string Replace (string text,char oldValue,char newValue)
{
    string result = string.Empty;//-инициализация пустой строки 
    int Length  = text.Length;
    for(int i=0;i<Length;i++)
    {
if(text[i]==oldValue)result=result+$"{newValue}";
else result=result+$"{text[i]}";
    }
 return result;
}
string newText = Replace (text,' ','|');
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace (newText,'k','K');
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace (newText,'C','c');
Console.WriteLine(newText);