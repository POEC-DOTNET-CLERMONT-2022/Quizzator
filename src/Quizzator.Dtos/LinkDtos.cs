using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzator.Quizzator.Dtos
{
    public class LinkDtos
    {
        public Guid Id { get; set; }
        public string Element { get; set; }

        public LinkDtos()
        {

        }

        public LinkDtos(Guid id, string element)
        {
            Id = id;
            Element = element;
        }

    }
}
