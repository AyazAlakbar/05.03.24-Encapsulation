// See https://aka.ms/new-console-template for more information
using _05._03._24_Encapsulation;

Console.WriteLine("Hello, World!");


User User = new User();
Console.WriteLine("enter username");
User.Username = Console.ReadLine();


while (User.Password==null)
{
Console.WriteLine("enter password");
User.Password = Console.ReadLine();

}
while (User.Age>0)
{
Console.WriteLine("Yas daxil edin:");
User.Age =Convert.ToInt32(Console.ReadLine()) ;
}

