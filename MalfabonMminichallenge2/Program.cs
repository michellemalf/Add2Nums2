//Michelle Malfabon
//Aug 10, 2022

//---------Mini Challenge 2 -- ADDING TWO NUMBERS----------//

//Description: Print the question using Console.Writeline and store user's input using Console.Readline, coverting into an integer with the convert method and stored in variables: number1 and number 2
//Lastly, print the solution in a sentence using interpolation. 

//Peer Review: Angelica


Console.WriteLine("Enter a number: ");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The total is {number1+ number2}!");
