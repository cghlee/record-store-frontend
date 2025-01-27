using System.ComponentModel.DataAnnotations;

namespace RecordStoreFE.Classes;

public class Album
{
    public int Id { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "The Album Name field is missing, or invalid Album Name entered.")]
    public string Name { get; set; } = "";

    [Required]
    [StringLength(100, ErrorMessage = "The Artist field is missing, or invalid Artist(s) entered.")]
    public string Artist { get; set; } = "";

    [Required]
    [StringLength(50, ErrorMessage = "The Composer field is missing, or invalid Composer entered.")]
    public string Composer { get; set; } = "";

    [EnumDataType(typeof(Genre))]
    public Genre Genre { get; set; }

    [Range(1850, 2100, ErrorMessage = "Invalid Year entered.")]
    public int Year { get; set; } = 1850;

    [Required]
    [Url(ErrorMessage = "The Album Art URL field is missing, or invalid URL entered.")]
    public string AlbumArtUrl { get; set; } = "";

    public Album() { }

    public Album(int id, string name, string artist, string composer, Genre genre, int year, string albumArtUrl)
    {
        Id = id;
        Name = name;
        Artist = artist;
        Composer = composer;
        Genre = genre;
        Year = year;
        AlbumArtUrl = albumArtUrl;
    }
}
