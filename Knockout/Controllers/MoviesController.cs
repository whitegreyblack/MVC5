using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace Knockout.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private readonly int seed;
        private readonly IEnumerable<ReleasedMovie> movies;

        private static string[] Cities = new[]
        {
            "Fargo", "Valley City", "Grand Forks", "Jamestown"
        };

        private static string[] Titles = new[]
        {
            "Ninjago", "Kingsman", "Pulselight", "Fandango", "Ronin", "Blade Runner"
        };

        private static string[] Times = new[]
        {
            "10:00 am", "12:00 pm", "1:30 pm", "4:00 pm", "6:30 pm", "9:00 pm", "11:30 pm"
        };

        private static string[] Genre = new[]
        {
            "Sci Fi", "Fantasy", "Romance", "Comedy", "Action", "Adventur", "Horror"
        };

        public MoviesController()
        {
            Console.WriteLine("Hah");

            seed = new Random().Next(100);
            var rng = new Random(seed);

            var client = new HttpClient();
            var times = rng.Next(Titles.Length);
 
            movies = Enumerable.Range(1, 4).Select(index => new ReleasedMovie
            {
                city = Cities[rng.Next(Cities.Length)],
                time = "",
                name = Titles[rng.Next(Titles.Length)],
                genre = ""
            });
        }

        [HttpGet("[action]")]
        public IEnumerable<ReleasedMovie> ReleasedMovies()
        {
            return movies;
        }

        public class ReleasedMovie
        {
            public string city { get; set; }
            public string time { get; set; }
            public string name { get; set; }
            //public string[] genre { get; set; }
            public string genre { get; set; }
        }
    }
}
