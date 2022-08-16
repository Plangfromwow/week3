/* 
 * 
 * Section 1: Create and populate the list of songs
 * 
 */
List<Song> playlist = new List<Song>();
Song song1 = new Song("The Beatles", "I want to hold your hand", "Rock", 1964);
playlist.Add(song1);
song1 = new Song("Pink Floyd", "Comfortably Numb", "Progressive", 1979);
playlist.Add(song1);
song1 = new Song("Britney Spears", "Toxic", "Pop", 2003);
playlist.Add(song1);
// We don't need a variable at all, we can just create the object and then put it directly in the lists add method. 
playlist.Add(new Song("Dave Brubek", "Take 5", "Jazz", 1959)); //Jeffs Favorite (Mine too)
//
// Section 2: Print out the titles
//
Console.WriteLine("Here is your playlist: ");
foreach (var song in playlist)
{
    Console.WriteLine(song.Title);
}
//
// Section 3: Ask the user for the song and print out the details.
//
Console.Write("Which song Title do you want more info on?");
string mySong = Console.ReadLine();
Song found = findSong(playlist,mySong);
if (found == null)
{
    Console.WriteLine("Sorry your song wasn't found");
}
else
{
    Console.WriteLine(found);
}
//
// Section 4: A "Helper" method to search the list by title.
// Side Note:We need to pass the list in
static Song findSong(List<Song> theList, string theTitle)
{
    foreach (Song next in theList)
    {
        if (next.Title.ToLower() == theTitle.ToLower())
        {
            return next;
        }
    }

    return null;
}

class Song
{
    public string Artist;
    public string Title;
    public string Genre;
    public int Year;

    public Song(string _artist, string _title, string _genre, int _year)
    {
        Artist = _artist;
        Title = _title;
        Genre = _genre;
        Year = _year;
    }


    public override string ToString()
    {
        return $"\"{Title}\" By: {Artist} From: {Year} Genre:{Genre}";
    }
}