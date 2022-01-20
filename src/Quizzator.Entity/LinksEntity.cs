using System;

namespace Quizzator.Entity
{
    public class LinksEntity
    {
        public Guid _Id { get; set; }
        public string Element { get; set; }
        public virtual ReponseEntity Reponse { get; set; }
        public LinksEntity(string element)
        {
            this.Element = element;
        }
    }
}