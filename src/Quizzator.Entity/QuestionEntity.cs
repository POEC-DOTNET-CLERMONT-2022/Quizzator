using System;
using System.Collections.Generic;

namespace Quizzator.Entity
{
    public class QuestionEntity
    {


        public Guid Id { get; set; }
        public string Texte { get; set; }
        public string ImagePath { get; set; }
        public ICollection<ReponseEntity> ReponseList { get; set; }
        public Guid ThemeId { get; set; } 

    }
}