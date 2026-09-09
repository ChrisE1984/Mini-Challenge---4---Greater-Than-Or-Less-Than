//Chris Estrada
//Date
//Assignment Name
//What you did
//Peer Review:
//Review:

Console.Clear();

Console.WriteLine("Please enter a number:");

int firstNumber = Console.ReadLine();

Console.WriteLine("Please enter a second number");

int secondNumber = Console.ReadLine();


if (firstNumber > secondNumber)
{
    Console.WriteLine("The First Number is Greater the Second number.");
}
else if (firstNumber == secondNumber)
{
    Console.WriteLine("The First Number is Equal to the Second number.");
}
else 
{
    Console.WriteLine("The First Number is less than the Second number.");
}

if (firstNumber < secondNumber)
{
    Console.WriteLine("The Second Number is Greater the First number.");
}
else if (firstNumber == secondNumber)
{
    Console.WriteLine("The Second Number is Equal to the First number.");
}
else 
{
    Console.WriteLine("The Second Number is less than the First number.");
}