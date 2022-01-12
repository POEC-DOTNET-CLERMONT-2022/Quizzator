using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Quizzator.Quizzator.Dtos
{
    [DataContract]
    public class ThemeDtos
    {
        public string _name { get; set; }
        public List<QuestionDtos> _question { get; set; }
        public string _imagePath { get; set; }

        public ThemeDtos(string name, string imagePath)
        {
            _name = name;
            _imagePath = imagePath;
            // TODO Check si cela ne va pas causer un conflit
            _question = new List<QuestionDtos>();
        }

        public ThemeDtos(string name, string imagePath, List<QuestionDtos> l) : this(name, imagePath)
        {
            _question = l;
        }
    }
}