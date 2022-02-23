using System;
using System.Collections.Generic;

namespace Quizzator.Entity
{
    public class ReponseEntity
    {
        public Guid Id { get; set; }
        public string Texte { get; set; }
        public string Explication { get; set; }
        public ICollection<LinksEntity> Liens { get; }
        public string ImagePath { get; set; }
        public Guid QuestionId { get; set; }
    }
}