using System.Collections.Generic;

namespace Quizzator.Quizzator.Dtos
{


    public class ReponseDtos
    {
        public string Texte { get; set; }
        public string Explication { get; set; }
        public IEnumerable<LinkDtos> Liens { get; set; }
        public string ImagePath { get; set; }

        public ReponseDtos()
        {

        }

        public ReponseDtos(string texte, string explication, List<LinkDtos> lien, string imagePath)
        {
            Texte=texte;
            Explication=explication;
            ImagePath=imagePath;
            Liens=lien;
        }

    }


}