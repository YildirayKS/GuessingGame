//Integers have been defined
int prediction;
int right = 3;
//Program name has been written to console
Console.WriteLine("***** Number guessing game! *****");
//Random number has been generated
Random rnd = new Random();
//The range of the number to be randomly generated is determined
int number = rnd.Next(1, 11);
//Loop started
for (int i = 0; i < 3; i++)
{
    //How many rights we have is written on the screen and the user is asked for a number
    Console.WriteLine("Make a guess (You have {0} rights):", right);
    //User guessed number taken
    prediction = Convert.ToInt32(Console.ReadLine());
    //If prediction is equal to number it will loop
    if (prediction == number)
    {
        // This loop happens if the guess is equal to the number
        Console.WriteLine("Your guess is correct!");
        break;
    }
    // This loop happens if the guess is not equal to the number
    else
    {
        //It is written that our guess is wrong and our right is reduced by one
        Console.WriteLine("Your guess is wrong!");
        right--;
        //If we run out of right this loop happens
        if (right == 0)
        {
            //We're told we're out of rights and the cycle ends
            Console.WriteLine("You have no more rights!");
            break;
        }
    }
}//The number is printed on the screen
Console.WriteLine("The generated number was {0}", number);