List<Movie> movieDatabase = new List<Movie>();
movieDatabase.Add(new Movie("Comedy","GhostBusters",1984, 105));
movieDatabase.Add(new Movie("Comedy", "Superbad", 2007, 114));
movieDatabase.Add(new Movie("Drama", "El Camino", 2019, 122));
movieDatabase.Add(new Movie("Horror", "Scream", 1996, 111));
movieDatabase.Add(new Movie("Horror", "The Babadook", 2014, 93));
movieDatabase.Add(new Movie("Action", "John Wick", 2014, 96));
movieDatabase.Add(new Movie("Action", "Morbius", 2022, 104));
movieDatabase.Add(new Movie("Comedy", "I've Run out of Ideas", 2022, 466));
movieDatabase.Add(new Movie("SciFi", "Star Wars: Episode IV – A New Hope", 1977, 105));
movieDatabase.Add(new Movie("SciFi", "Star Trek", 2009, 127));

string categorySelected = "";
Console.WriteLine($"Welcome to the Movie Database! There are currently {movieDatabase.Count} movies!");

do
{
    List<string> categories = new List<string>();
    foreach (Movie genre in movieDatabase)
    {
        if (categories.IndexOf(genre.category) == -1)
        {
            categories.Add(genre.category);
        }
    }

    // found the categories lets do another loop to print them out 

    foreach (string category in categories)
    {
        Console.WriteLine(category);
    }
    Console.WriteLine();

    Console.WriteLine("We have a wide variety of movies, please select a Category to get started!");
    Console.WriteLine();
    Console.WriteLine("Options are: ");
    Console.WriteLine("[1]Comedy [2]Drama [3]Horror [4]Action [5]Comedy [6]SciFi");
    Console.Write("Plesase select and option: ");
    int userInput = int.Parse(Console.ReadLine());
    switch (userInput)
    {
        case 1:
            Console.WriteLine("You've selected option 1!");
            categorySelected = "Comedy";
            findMovie(movieDatabase, categorySelected);
            break;
        case 2:
            Console.WriteLine("You've selected option 2!");
            categorySelected = "Drama";
            findMovie(movieDatabase, categorySelected);
            break;
        case 3:
            Console.WriteLine("You've selected option 3!");
            categorySelected = "Horror";
            findMovie(movieDatabase, categorySelected);
            break;
        case 4:
            Console.WriteLine("You've selected option 4!");
            categorySelected = "Action";
            findMovie(movieDatabase, categorySelected);
            break;
        case 5:
            Console.WriteLine("You've selected option 5!");
            categorySelected = "Comedy";
            findMovie(movieDatabase, categorySelected);
            break;
        case 6:
            Console.WriteLine("You've selected option 6!");
            categorySelected = "SciFi";
            findMovie(movieDatabase, categorySelected);
            break;

        default:
            Console.WriteLine("Sorry, that's not a valid option. Please select one of the available numbers");
            break;
    }
    Console.WriteLine();


} while (KeepGoing());





static bool KeepGoing()
{
    while (true)
    {
        // Print out message asking if user wants to continue
        Console.WriteLine("Would you like to see another category? (y/n)");
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



static void findMovie(List<Movie> theList, string theCategory)
{
    foreach (Movie next in theList)
    {
        if (next.category.ToLower() == theCategory.ToLower())
        {
            Console.WriteLine(next);
        }
    }

    
}



class Movie
{
    public string category;
    public string name;
    public int releaseDate;
    public int runTime;

    public Movie(string _category, string _name, int _releaseDate, int _runTime)
    {
        category = _category;
        name = _name;
        releaseDate = _releaseDate;
        runTime = _runTime;
    }


    public override string ToString()
    {
        return $"\"{name}\" Released:{releaseDate} Category:{category} RunTime:{runTime}min ";
    }

}