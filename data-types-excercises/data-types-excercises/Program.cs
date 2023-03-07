/*Console.WriteLine("What is the length of the rectangle");
string length = Console.ReadLine();

Console.WriteLine("What is the width of the rectangle");
string width = Console.ReadLine();

int area = int.Parse(width) * int.Parse(length);
Console.WriteLine("The area of the rectangle is " +area);

Console.WriteLine("How many miles have you driven");
string miles = Console.ReadLine();

Console.WriteLine("How much gas have you consumed");
string gas = Console.ReadLine();

int milesPerGallon = int.Parse(miles) / int.Parse(gas);
Console.WriteLine("Your miles per gallon is " + milesPerGallon); */



string alice = @"Alice was beginning to get very tired of sitting by her sister on the
   bank, and of having nothing to do: once or twice she had peeped into the
   book her sister was reading, but it had no pictures or conversations in
   it, 'and what is the use of a book,' thought Alice 'without pictures or
   conversation?'";

Console.WriteLine(alice);
Console.WriteLine("What sentence would you like to look for in the sentence above?");
string searchTerm = Console.ReadLine();
string compSearchTerm = searchTerm.ToLower();
string compAlice = alice.ToLower();

if (compAlice.IndexOf(compSearchTerm, 0) != -1)
{
    int indexOfSearch = compAlice.IndexOf(compSearchTerm);
    int lengthOfSearchTerm = compSearchTerm.Length;
    string newAlice = compAlice.Remove(indexOfSearch, lengthOfSearchTerm);
    Console.WriteLine("true");
    Console.WriteLine(newAlice);
}
else
{
    Console.WriteLine("false");
}