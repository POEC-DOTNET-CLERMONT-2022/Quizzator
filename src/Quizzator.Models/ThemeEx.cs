using System.Collections.Generic;

namespace Quizzator.Quizzator.Models
{
    public class ThemeEx
    {
        public string _name { get; set; }
        public List<Question> _question { get; set; }
        public string _ImagePath { get; set; }

        public ThemeEx(string name, string imagePath)
        {
            _name = name;
            _ImagePath = imagePath;
            // TODO Check si cela ne va pas causer un conflit
            _question = new List<Question>();
        }

        public ThemeEx(string name, string imagePath, List<Question> l) : this(name, imagePath)
        {
            _question = l;
        }

    }
}
