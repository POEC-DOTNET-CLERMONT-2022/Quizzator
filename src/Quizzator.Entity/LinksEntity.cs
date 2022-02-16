using System;

namespace Quizzator.Entity
{
    public class LinksEntity
    {
        public Guid Id { get; set; }
        public string Element { get; set; }
        public ReponseEntity Reponse { get; set; }
        public Guid ReponseId { get; set; }

    }
}