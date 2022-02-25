using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Quizzator.Quizzator.Dtos
{
    [DataContract]
    public class ThemeDtos
    {
        public Guid Id { get; set; }
        public string ThemeName { get; set; }
        public string ImagePath { get; set; }
        public bool IsVisible { get; set; }
        public ICollection<QuestionDtos> Questions { get; set; }

        public ThemeDtos()
        {

        }

        public ThemeDtos(string name, string imagePath, ICollection<QuestionDtos> question)
        {
            ThemeName = name;
            ImagePath = imagePath;
            // TODO Check si cela ne va pas causer un conflit
            Questions = question;
        }

       
    }
}