Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.Write("Ура это же Маха ");
}
else{
     Console.Write("Привет , ");
     Console.WriteLine(username);
}