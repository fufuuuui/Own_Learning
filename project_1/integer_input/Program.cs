string? readResult;
bool valid = false; 
int numericValue = 0;

Console.WriteLine("Enter an integer value between 5 and 10:");
do
{
    readResult = Console.ReadLine(); 
    if (int.TryParse(readResult, out numericValue))
            if (numericValue > 10 || numericValue < 5)
            {
                Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
            }
            else if (numericValue >= 5 && numericValue <= 10)
            {
                valid = true;
                Console.WriteLine($"Your input value ({numericValue}) has been accepted.");
            }
            else
            {
                Console.WriteLine("Sorry, you entered an invalid number, please try again");
            }
}while (valid == false);
