namespace BlazorApp.Data.Models;

public class Movie
{

    public int Id { get; set; }
    public string Title { get; set; }
    public string Director { get; set; }
    public int ReleaseYear { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }


    public bool hasCategory(int id)
    {
        if (Category == null){
            return false;
        }
        return Category.Id == id;
    }
}