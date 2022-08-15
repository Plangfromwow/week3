//compactDisc

compactDisc TheWall = new compactDisc("Pink Floyd", "Rock",80);

Console.WriteLine(TheWall.ToString());
TheWall.songs.Add("The Thin Ice");
TheWall.songs.Add("In the Flesh?");
TheWall.songs.Add("Another Brick in the Wall, Part 1");
TheWall.songs.Add("The Happiest Days of our Lives");
TheWall.songs.Add("Another Brick in the Wall, Part 2");

foreach (string song in TheWall.songs)
{
    Console.WriteLine(song);
}
Console.WriteLine($"This album has {TheWall.songCount()} songs");

// lets practice copying
// we have the same object referenced by two 
compactDisc another = TheWall;
Console.WriteLine(another.artist);

printAlbumInfo(another);


static void printAlbumInfo(compactDisc cd)
{

    Console.WriteLine("======Album Info======");
    Console.WriteLine(cd.ToString());

    foreach (string song in cd.songs)
    {
        Console.WriteLine(song);
    }
}

class compactDisc
{
    public string artist;
    public string genre;
    public int duration;
    public List<string> songs;

    public compactDisc(string _artist,string _genre,int _duration)
    {
        artist = _artist;
        genre = _genre;
        duration = _duration;
        songs = new List<string>();
    }

    public int songCount()
    {
        return songs.Count;
    }





    public override string ToString()
    {
        return $"Artist:{artist} Genre:{genre} Duration:{duration} minutes";
    }
}

