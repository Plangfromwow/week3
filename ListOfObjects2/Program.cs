List<Song> playlist = new List<Song>();
Song song1 = new Song("The Beatles", "I want to hold your hand", "Rock", 1964);
playlist.Add(song1);
//Song song2 = new Song("Pink Floyd", "Comfortably Numb", "Progressive", 1979);
//playlist.Add(song2);
//Song song3 = new Song("Britney Spears", "Toxic", "Pop", 2003);
//playlist.Add(song3);
// we don't need to keep making a new variable after we put the object in the list. The list then becomes what hold that variable to that song.
song1 = new Song("Pink Floyd", "Comfortably Numb", "Progressive", 1979);
playlist.Add(song1);
song1 = new Song("Britney Spears", "Toxic", "Pop", 2003);
playlist.Add(song1);
// We don't need a variable at all, we can just create the object and then put it directly in the lists add method. 
playlist.Add(new Song("Dave Brubek", "Take 5", "Jazz", 1959));
Console.WriteLine("Here is your playlist: ");
foreach (var song in playlist)
{
    Console.WriteLine(song.Title);
}


Console.Write("Which song Title do you want more info on?");
string mySong = Console.ReadLine();
Song found = null;

foreach (Song next in playlist)
{
    if (next.Title == mySong)
    {
        found = next;
        break;
    }
}

if (found == null)
{
    Console.WriteLine("Sorry your song wasn't found");
}
else
{
    Console.WriteLine(found);
}

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