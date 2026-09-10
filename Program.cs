//Chris Estrada
//9-10-26
//Mini Challenge 4 - Greater Than or Less Than
//Created a program that prompts the user for 2 number inputs then tells the user if the numbers are greater, less than, or equal to each other.
//Peer Review:
//Review:

Console.Clear();

Console.WriteLine("Please enter a number:");// Initial prompts

string firstNumber = Console.ReadLine();

Console.WriteLine("Please enter a second number");

string secondNumber = Console.ReadLine();

int actualFirstNum = Convert.ToInt32 (firstNumber);// Needed to convert first string to int for if/else if statement

int actualSecondNum = Convert.ToInt32 (secondNumber);// Needed to convert second string to int for if/else if statement

//If/else/if statements, requested two sentences to compare so 2 statements needed
if (actualFirstNum > actualSecondNum)
{
    Console.WriteLine("The First Number is Greater the Second number.");
}
else if (actualFirstNum == actualSecondNum)
{
    Console.WriteLine("The First Number is Equal to the Second number.");
}
else 
{
    Console.WriteLine("The First Number is less than the Second number.");
}

if (actualFirstNum < actualSecondNum)
{
    Console.WriteLine("The Second Number is Greater the First number.");
}
else if (actualFirstNum == actualSecondNum)
{
    Console.WriteLine("The Second Number is Equal to the First number.");
}
else 
{
    Console.WriteLine("The Second Number is less than the First number.");
}