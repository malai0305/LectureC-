Console.Write("Введите имя пользователя:");
string myname = Console.ReadLine();
if(myname.ToLower() == "артём")
{
  Console.WriteLine ("Ура,это же Артём!!!");
}
else 
{
    Console.Write("Привет,");
    Console.WriteLine(myname);
}