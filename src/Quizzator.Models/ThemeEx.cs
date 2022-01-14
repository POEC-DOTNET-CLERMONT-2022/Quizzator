using System.Collections.Generic;

namespace Quizzator.Quizzator.Models
{
    public class ThemeEx
    {
        public string _Name { get; set; }
        public List<Question> _Question { get; set; }
        public string _ImagePath { get; set; }

        public ThemeEx(string name, string imagePath)
        {
            _Name = name;
            _ImagePath = imagePath;
            // TODO Check si cela ne va pas causer un conflit
            _Question = new List<Question>();
        }

        public ThemeEx(string name, string imagePath, List<Question> l) : this(name, imagePath)
        {
            _Question = l;
        }

    }
}
