using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace Knockout
{

    public class Parser
    {
        private readonly IEnumerable<Movie> movies;

        public Parser()
        {
            // get html data
        }

        class Movie
        {
            public string city { get; set; }
            public string times { get; set; }
            public string titles { get; set; }
            public string rating { get; set; }
            public string length { get; set; }
        }

    }
}
