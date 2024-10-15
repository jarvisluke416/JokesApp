using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace JokerApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }

        public Joke()
        {

        }
    }
}
