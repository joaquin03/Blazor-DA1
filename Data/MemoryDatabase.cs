namespace BlazorApp.Data;

using BlazorApp.Data.Models;

public class MemoryDatabase{
    public List<Movie> Movies { get; set; } = new List<Movie>();
    public List<Category> Categories { get; set; } = new List<Category>();  


    public MemoryDatabase()
    {
        this.AddDefaultMovies();
        this.AddDefaultCategories();
    }

    public void AddCategory(Category category)
    {
        category.Id = Categories.Count + 1;
        Categories.Add(category);
    }

    public Category FindCategory(int id)
    {
        return Categories.FirstOrDefault(c => c.Id == id);
    }

    public void UpdateCategory(Category element)
    {
        MemoryDatabase.Categories = MemoryDatabase.Categories.Select(e => e.Id == element.Id ? element : e).ToList();
    }

    public void DeleteCategory(Category element)
    {
        MemoryDatabase.Categories.RemoveAll(x => x.Id == id);
    }


    private void AddDefaultMovies()
    {
        Movies.Add(new Movie { Id = 1, Title = "The Shawshank Redemption", Director = "Frank Darabont", ReleaseYear = 1994 });
        Movies.Add(new Movie { Id = 2, Title = "The Godfather", Director = "Francis Ford Coppola", ReleaseYear = 1972 });
        Movies.Add(new Movie { Id = 3, Title = "The Godfather: Part II", Director = "Francis Ford Coppola", ReleaseYear = 1974 });
        Movies.Add(new Movie { Id = 4, Title = "The Dark Knight", Director = "Christopher Nolan", ReleaseYear = 2008 });
        Movies.Add(new Movie { Id = 5, Title = "The Lord of the Rings: The Return of the King", Director = "Peter Jackson", ReleaseYear = 2003 });
        Movies.Add(new Movie { Id = 6, Title = "Pulp Fiction", Director = "Quentin Tarantino", ReleaseYear = 1994 });
        Movies.Add(new Movie { Id = 7, Title = "Schindler's List", Director = "Steven Spielberg", ReleaseYear = 1993 });
    }
    private void AddDefaultCategories()
    {
        Categories.Add(new Category { Id = 1, Name = "Action" });
        Categories.Add(new Category { Id = 2, Name = "Comedy" });
        Categories.Add(new Category { Id = 3, Name = "Drama" });
        Categories.Add(new Category { Id = 4, Name = "Horror" });
        Categories.Add(new Category { Id = 5, Name = "Romance" });
        Categories.Add(new Category { Id = 6, Name = "Thriller" });
    }


}