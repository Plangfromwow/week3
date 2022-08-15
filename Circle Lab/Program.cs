// have user input the radius for the circle 
// after that, the app calls the instances for Area and Circumfrance to get the numbers
// Print the answers out to the user and ask if they want to go again 
// create a goodbye message 
// create a counter to let the user know how many circles they've created 

double userRadius;
Console.WriteLine("Welcome to the Circle Generator!");
bool makeAnotherCircle = true;
int circleCount = 1;
do
{
    Console.Write("Please input the radius for your cirlce: ");
    string input = Console.ReadLine();
    bool validateInput = double.TryParse(input, out userRadius);
    if (!validateInput)
    {
        Console.WriteLine("Please enter a valid number for Radius");
    }
    else if (validateInput)
    {
        circle userCircle = new circle(userRadius);
        Console.WriteLine();
        Console.WriteLine("That's a nice circle!");
        Console.WriteLine($"The Area is: {userCircle.printArea()} The Circumfrance is: {userCircle.printCircumfrance()}");
        Console.WriteLine($"You've made {circleCount} Circles!");
        circleCount++;
        makeAnotherCircle = KeepGoing();
    }

    
}while (makeAnotherCircle);

Console.WriteLine($"Great work making {circleCount} circle(s)!");

static bool KeepGoing()
{
    while (true)
    {
        // Print out message asking if user wants to continue
        Console.WriteLine("Would you like to make another circle? (y/n)");
        // Ask the user for their input
        string response = Console.ReadLine();
        response = response.ToLower();
        // Check if they typed "y". If so, return true.
        // Otherwise return false.   YES   yes
        if (response == "y" || response == "yes")
        {
            return true;
        }
        else if (response == "n" || response == "no")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Please enter y or n");
        }
    }
}

class circle
{
    double radius;
    double pi = Math.PI;


    public circle(double input)
    {
        radius = input;
    }

    public void printRadius()
    {
        Console.WriteLine($"The radius of your circle is {radius}");
    }


    public double printArea()
    {
        double area = pi * (radius * radius);
        return area;
    }
    
    public double printCircumfrance()
    {
        double circumfrance = 2 * pi * radius;
        return circumfrance;
    }

}


