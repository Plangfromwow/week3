List<Song> playlist = new List<Song>();
Song song1 = new Song("The Beatles", "I want to hold your hand","Rock",1964);
playlist.Add(song1);
Song song2 = new Song("Pink Floyd", "Comfortably Numb", "Progressive", 1979);
playlist.Add(song2);
Song song3 = new Song("Britney Spears", "Toxic", "Pop", 2003);
playlist.Add(song3);

Console.WriteLine("here are your songs:");
foreach (var song in playlist)
{
    Console.WriteLine(song.Title);
}
Console.WriteLine();
Console.Write("Which song would you want more details on?");
string mysong = Console.ReadLine();







class Song
{
    public string Artist;
    public string Title;
    public string Genre;
    public int Year;

    public Song(string _artist, string _title ,string _genre, int _year)
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