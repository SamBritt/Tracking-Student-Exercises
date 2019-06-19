using System;

namespace StudentExercises
{
    public class Exercise
    {
        public Exercise(string name, string language)
        {
            this.name = name;
            this.language = language;
        }

        public string name { get; set; }
        public string language { get; set; }
    }
}