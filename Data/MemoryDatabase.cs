namespace BlazorApp.Data;

public class MemoryDatabase{
    public List<Movie> Movies { get; set; } = new List<Movie>();


    public MemoryDatabase()
    {
        this.AddMovies();
    
    }

    private void AddMovies()
    {
        Movies.Add(new Movie { Id = 1, Title = "The Shawshank Redemption", Director = "Frank Darabont", ReleaseYear = 1994 });
        Movies.Add(new Movie { Id = 2, Title = "The Godfather", Director = "Francis Ford Coppola", ReleaseYear = 1972 });
        Movies.Add(new Movie { Id = 3, Title = "The Godfather: Part II", Director = "Francis Ford Coppola", ReleaseYear = 1974 });
        Movies.Add(new Movie { Id = 4, Title = "The Dark Knight", Director = "Christopher Nolan", ReleaseYear = 2008 });
        Movies.Add(new Movie { Id = 5, Title = "The Lord of the Rings: The Return of the King", Director = "Peter Jackson", ReleaseYear = 2003 });
        Movies.Add(new Movie { Id = 6, Title = "Pulp Fiction", Director = "Quentin Tarantino", ReleaseYear = 1994 });
        Movies.Add(new Movie { Id = 7, Title = "Schindler's List", Director = "Steven Spielberg", ReleaseYear = 1993 });
    }

}