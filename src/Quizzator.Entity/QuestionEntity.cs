using System;
using System.Collections.Generic;

namespace Quizzator.Entity
{
    public class QuestionEntity
    {


        public Guid _Id { get; set; }
        public string _Texte { get; set; }
        public string _ImagePath { get; set; }
        public List<ReponseEntity> _ReponseList { get; set; }
        public ThemeExEntity ThemeEx { get; set; }

    }
}