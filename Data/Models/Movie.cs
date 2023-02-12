namespace BlazorApp.Data.Models;

public class Movie
{

    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Director { get; set; }
    public int? ReleaseYear { get; set; }

    public Category? Category { get; set; }
    public List<Actor>? Actors { get; set; }


    public override string ToString()
    {
        return $"Id: {Id}, Title: {Title}, Director: {Director}, ReleaseYear: {ReleaseYear}, Category: {Category}";
    }

    public bool hasActor(int id)
    {
        if (Actors == null)
            return false;
        return Actors.Any(a => a.Id == id);
    }
}