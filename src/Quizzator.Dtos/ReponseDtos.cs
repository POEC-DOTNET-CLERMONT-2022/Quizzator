using System.Collections.Generic;

namespace Quizzator.Quizzator.Dtos
{


    public class ReponseDtos
    {
        private string _Texte { get; set; }
        private string _Explication { get; set; }
        private List<string> _Lien { get; } = new List<string>();
        private string _ImagePath { get; set; }
        private bool _isTroll { get; set; }

        public ReponseDtos(string texte, string explication, List<string> Lien, string ImagePath, bool istroll)
        {
            _Texte=texte;
            _Explication=explication;
            _ImagePath=ImagePath;
            _Lien=Lien;
            _isTroll = istroll;
        }

    }


}