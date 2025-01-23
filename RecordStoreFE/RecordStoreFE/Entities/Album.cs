namespace RecordStoreFE.Classes;

public class Album
{
    public int Id { get; set; }

    public string Name { get; set; } = "";

    public string Artist { get; set; } = "";

    public string Composer { get; set; } = "";

    public Genre Genre { get; set; }

    public int Year { get; set; }
}
