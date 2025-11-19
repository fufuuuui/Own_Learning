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

// Better Code

// string? readResult;
// string valueEntered = "";
// int numValue = 0;
// bool validNumber = false;

// Console.WriteLine("Enter an integer value between 5 and 10");

// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null) 
//     {
//         valueEntered = readResult;
//     }

//     validNumber = int.TryParse(valueEntered, out numValue);

//     if (validNumber == true)
//     {
//         if (numValue <= 5 || numValue >= 10)
//         {
//             validNumber = false;
//             Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
//         }
//     }
//     else 
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     }
// } while (validNumber == false);

// Console.WriteLine($"Your input value ({numValue}) has been accepted.");

// readResult = Console.ReadLine();
