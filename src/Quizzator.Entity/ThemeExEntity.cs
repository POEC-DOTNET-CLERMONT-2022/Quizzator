using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Quizzator.Entity 
{ 

    public class ThemeExEntity
    {
        public Guid _Id { get; set; }
        public string _Name { get; set; }
        public List<QuestionEntity> _Questions { get; set; }
        public string _ImagePath { get; set; }
        public bool IsVisible { get; set; }

        public ThemeExEntity(string name, string imagePath)
        {
            _Name = name;
            _ImagePath = imagePath;
            _Questions = new List<QuestionEntity>();
        }

        public ThemeExEntity(string name, string imagePath, List<QuestionEntity> l) : this(name, imagePath)
        {
            _Questions = l;
        }
    }
}