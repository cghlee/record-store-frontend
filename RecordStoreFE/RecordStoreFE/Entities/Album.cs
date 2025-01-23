namespace RecordStoreFE.Classes;

public class Album
{
    public int Id { get; set; }

    public string Name { get; set; } = "";

    public string Artist { get; set; } = "";

    public string Composer { get; set; } = "";

    public Genre Genre { get; set; }

    public int Year { get; set; }

    public Album(int id, string name, string artist, string composer, Genre genre, int year)
    {
        Id = id;
        Name = name;
        Artist = artist;
        Composer = composer;
        Genre = genre;
        Year = year;
    }
}
