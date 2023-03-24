namespace Task2.Model
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }

        public Movie(int id, string name, double rating)
        {
            Id = id;
            Name = name;
            Rating = rating;
        }
    }

}
