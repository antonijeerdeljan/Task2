using Microsoft.AspNetCore.Mvc;
using Task2.Model;
using Task2.Repository;

namespace Task2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {

        private readonly MovieRepository repository = new MovieRepository();

        [HttpGet("GetAll")]
        public IEnumerable<Movie> GetAllMovies()
        {
           return repository.GetAllMovies();
        }
        
        [HttpPost("GetById{id}")]
        public Movie GetMovieById(int id)
        {
            return repository.GetAllMovies().Where(m => m.Id == id).First();
        }

        [HttpDelete("{id}")]
        public List<Movie> DeleteMovieById(int id)
        {
            List<Movie> allMovies = repository.GetAllMovies();
            Movie movieToDelete = allMovies.FirstOrDefault(m => m.Id == id);
            if(allMovies.Remove(movieToDelete) == true)
            {
                return allMovies;
            }
            else
            {
                return null;
            }
        }
    }
}
