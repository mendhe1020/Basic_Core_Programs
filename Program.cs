
Console.WriteLine("Enter the name");
string username = Console.ReadLine();

if (username.Length > 3)
{
    Console.WriteLine("Hello " + username + " ,How are you?");
}
else
{
    Console.WriteLine("the username has minimum 3 characters");
}