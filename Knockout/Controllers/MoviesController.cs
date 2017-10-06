using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Knockout.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
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

        [HttpGet("[action]")]
        public IEnumerable<ReleasedMovie> ReleasedMovies()
        {
            var rng = new Random();

            var times = rng.Next(Titles.Length);

            return Enumerable.Range(1, 4).Select(index => new ReleasedMovie
            {
                city = Cities[rng.Next(Cities.Length)],
                time = "",
                name = Titles[rng.Next(Titles.Length)],
                genre = ""
                //genre = new[]
                //{
                //    Genre[rng.Next(Genre.Length)],
                //    Genre[rng.Next(Genre.Length)]
                //}
            });
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
