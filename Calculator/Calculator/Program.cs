// See https://aka.ms/new-console-template for more information
int num1,num2,result;
string operation;
Console.WriteLine("Hello, World!");
Console.WriteLine("Please Enter the first number");
num1 =Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Please Enter the second number");
num2=Convert.ToInt32( Console.ReadLine());
Console.WriteLine("What type of operation would you like to do?");
Console.WriteLine("Please Enter a for addition, s for subtraction,m for multiplication,d for division");
operation = Console.ReadLine();
switch (operation)
{
    case "a":result = num1 + num2; Console.WriteLine(result);break;
    case "m":result = num1 * num2; Console.WriteLine(result);break;
    case "s":result = num1 - num2; Console.WriteLine(result);break;
    case "d":result = num1 / num2; Console.WriteLine(result);break;
    default: Console.WriteLine("You have Chosen the wrong letter "+operation);break;
}