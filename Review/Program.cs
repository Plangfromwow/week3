//bool has two choices for values False:True
bool goAgain = true;
Console.WriteLine(goAgain); // How can you use write line with all the different types? Overloading
goAgain = false;
Console.WriteLine(goAgain); // expect to see False
//How to flip a boolean from True > False or VV
goAgain = !goAgain;
Console.WriteLine(goAgain);
// Int roughly 4bil possible choices
int count = 10;
Console.WriteLine(count);
//Operators: Increment and Decrement 
count++; //adds one to count 
count--; // decreseas count 
// single char: Use single quotes around it and only one character. 
// USELESS: These are unicode characters. google it.
Console.WriteLine();
Console.WriteLine("Character Tests");
char ch = 'a';

string words = "The quick brown fox jumps over the lazy dogs.";
Console.WriteLine(words);

string[] parts = words.Split();

foreach (string word in parts)
{
    Console.WriteLine(word);
}
// Needs seperator for this join
string copy = string.Join(" ", parts);
Console.WriteLine(copy); // Puts the string back together 
// search for substring "fox"
int pos = words.IndexOf("fox");
pos = words.IndexOf("cat"); // if indexof can't find what it's looking for it will return -1
if (pos >= 0)
{
    Console.WriteLine("Found it!");
}
else
{
    Console.WriteLine("Does not exist!");
}
words += " No cats allowed.";

// creating a list of rectangle instances. 
List<Rectangle> myList = new List<Rectangle>();
myList.Add(new Rectangle("first",10.5,20.6));
myList.Add(new Rectangle("second", 25.6, 13.2));
myList.Add(new Rectangle("third", 15.0, 24.6));
// Dictionary Practice 

Dictionary<string,int> myDictionary = new Dictionary<string,int>();
myDictionary["One"] = 1;
myDictionary["fifty"] = 50;

myDictionary.Add("OneHundred", 100);

//foreach (var pair in myDictionary)
foreach (KeyValuePair<string,int> pair in myDictionary)
{
    Console.WriteLine($"{pair.Key} maps to {pair.Value}");
}

//Enums


season now = season.Summer;
Console.WriteLine(now);
// technically stored as numbers
enum season
{
    Winter,
    Spring,
    Summer,
    Fall
}


class Rectangle
{
    public string name;
    public double height;
    public double length;

    public Rectangle(string _name, double _height, double _length)
    {
        name = _name;
        height = _height;
        length = _length;
    }



    public override string ToString()
    {
        return base.ToString();
    }

}