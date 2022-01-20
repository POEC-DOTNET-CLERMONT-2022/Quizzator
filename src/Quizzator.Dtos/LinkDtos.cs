using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzator.Quizzator.Dtos
{
    internal class LinkDtos
    {
        public Guid LinkId { get; set; }
        public string Element { get; set; }
        public ReponseDtos Reponse { get; set; }

    }
}
