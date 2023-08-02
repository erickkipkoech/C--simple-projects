// See https://aka.ms/new-console-template for more information
bool isCorrectGuess=false;
Random random = new Random();
int guessNum=random.Next(1,11);
Console.WriteLine("Hello, World! Welcome to the number guessing game");
Console.WriteLine("A number between one and ten wil be generated.");
Console.WriteLine("If you guess the correct number, you win!");

Console.WriteLine("-------------");
Console.WriteLine("Guess a number: ");
int guess=Convert.ToInt32(Console.ReadLine());

if (guess == guessNum)
{
    Console.WriteLine("You win!");
    Console.WriteLine("Guess number is "+guessNum);
}
else if (guess!=guessNum)
{
    Console.WriteLine("You lose");
    Console.WriteLine("Guess number is " + guessNum);
}
else
{
    Console.WriteLine("Number is out of range!");
}

