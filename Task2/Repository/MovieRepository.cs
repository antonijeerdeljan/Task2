using Task2.Model;

namespace Task2.Repository
{
    public class MovieRepository
    {
        public List<Movie> GetAllMovies() {
            List<Movie> movies = new List<Movie>
            {
            new Movie(1, "The Shawshank Redemption", 9.3),
            new Movie(2, "The Godfather", 9.2),
            new Movie(3, "The Dark Knight", 9.0),
            new Movie(4, "The Lord of the Rings: The Return of the King", 8.9),
            new Movie(5, "Pulp Fiction", 8.9)
            };
            return movies;
        }
    }
}
