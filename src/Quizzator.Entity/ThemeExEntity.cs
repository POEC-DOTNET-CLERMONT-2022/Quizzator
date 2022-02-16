using System;
using System.Collections.Generic;

namespace Quizzator.Entity 
{ 

    public class ThemeExEntity
    {
        public Guid Id { get; set; }
        public string ThemeName { get; set; }
        public ICollection<QuestionEntity> Questions { get; set; }
    }
}