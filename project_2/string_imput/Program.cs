using System.Reflection;

string? readInput;
bool success = true;
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
do
{
    readInput = Console.ReadLine().ToLower().Trim();
    if (readInput != null)
    {
        if(readInput == "Administrator")
        {
            Console.WriteLine($"Your input value ({readInput}) has been accepted.");
            success = false;
        }
        else if (readInput == "Manager")
        {
            Console.WriteLine($"Your input value ({readInput}) has been accepted.");
            success = false;
        }
        else
        {
            Console.WriteLine($"The role name that you entered, \"{readInput}\" is not valid. Enter your role name (Administrator, Manager, or User)");
            success = false;
        }
    }
}while(success);