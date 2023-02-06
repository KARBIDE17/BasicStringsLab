using System.Diagnostics.Metrics;
do
{ 
Console.WriteLine("Please write me a sentence so that i can split it up into individual words");

string fullSentence = Console.ReadLine();

string[] splitResult = fullSentence.Split(' ');


for (int i = 0; i < splitResult.Length; i++)
{
    Console.WriteLine(splitResult[i]);
}
Console.WriteLine("Would you like to learn about another student? y/n?"); //continue running with a prompt at the end to see if they want to stop. 
string choice2 = Console.ReadLine();
while (choice2 != "y" && choice2 != "Y")
{
    Console.WriteLine("Goodbye!");
    return;

}
} while (true) ;