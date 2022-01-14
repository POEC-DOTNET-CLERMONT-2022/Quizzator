using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Quizzator.Quizzator.Dtos
{
    [DataContract]
    public class ThemeDtos
    {
        public string _Name { get; set; }
        public List<QuestionDtos> _Question { get; set; }
        public string _ImagePath { get; set; }
        public bool IsVisible { get; set; }

        public ThemeDtos(string name, string imagePath)
        {
            _Name = name;
            _ImagePath = imagePath;
            // TODO Check si cela ne va pas causer un conflit
            _Question = new List<QuestionDtos>();
        }

        public ThemeDtos(string name, string imagePath, List<QuestionDtos> l) : this(name, imagePath)
        {
            _Question = l;
        }
    }
}