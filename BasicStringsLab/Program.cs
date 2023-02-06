/*
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
*/


//Description
//Repeatedly prompt the user to enter a string.  Store the string in a list and display the contents of the list with each element separated by a space.

//Example
//>>Enter some text: << The
//<< You have entered: The
//Would you like to continue (y/n)? << y
//>> Enter some text: << cow
//<< You have entered: The cow
//Would you like to continue (y/n)? << y
//>> Enter some text: << jumped...
//<< You have entered: The cow jumped...
//Would you like to continue (y/n)? << n
//>> Goodbye!


List<string> masterList = new List<string>();
do
{ 
while (true)
{
    Console.Write("Please enter a word, and press enter to add it to the list. ");
    string input = Console.ReadLine();

        masterList.Add(input);
        Console.WriteLine();
        Console.WriteLine("Here is each item stored in the list: ");
        foreach (string item in masterList)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Would you like to add another word? y/n?");
        //continue running with a prompt at the end to see if they want to stop. 
        string choice2 = Console.ReadLine();
        while (choice2 != "y" && choice2 != "Y")
        {
            Console.WriteLine();
            Console.WriteLine("Here is your completed list of entries: " );
            foreach (string item in masterList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("Goodbye!");
            return;

        }
    }


} while (true) ;