using System;
using System.Collections.Generic;

namespace Quizzator.Entity
{
    public class ReponseEntity
    {
        public Guid _Id { get; set; }
        public string _Texte { get; set; }
        public string _Explication { get; set; }
        public List<LinksEntity> _Lien { get; } = new List<LinksEntity>();
        public string _ImagePath { get; set; }
        public bool _isTroll { get; set; }
        public QuestionEntity Question { get; set; }
    }
}