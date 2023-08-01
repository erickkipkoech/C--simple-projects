// See https://aka.ms/new-console-template for more information
int playerRandomNum;
int enemyRandomNum;

int playerPoints=0;
int enemyPoints=0;
Random random=new Random();
for(int i = 0; i < 10; i++)
{
Console.WriteLine("Press any Key to roll the dice");
    Console.ReadKey();

    playerRandomNum = random.Next(1,8);
    Console.WriteLine("You rolled a " + playerRandomNum);

    Console.WriteLine("...");
    System.Threading.Thread.Sleep(1000);

    enemyRandomNum = random.Next(1,8);
    Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);

    if (playerRandomNum > enemyRandomNum)
    {
        playerPoints++;
        Console.WriteLine("Player wins this round");
    }else if(enemyRandomNum>playerRandomNum){
        enemyPoints++;
        Console.WriteLine("Enemy wins this round");
    }
    else
    {
        Console.WriteLine("Draw!");
    }

    Console.WriteLine("The score is now -Player "+playerPoints+". -Enemy "+enemyPoints);
    Console.WriteLine("-----------------------------------------------------------");

    if (playerPoints > enemyPoints)
    {
        Console.WriteLine("You win!");
    }else if (enemyPoints > playerPoints)
    {
        Console.WriteLine("You lose!");
    }
    else
    {
        Console.WriteLine("It's a draw!");
    }
}

