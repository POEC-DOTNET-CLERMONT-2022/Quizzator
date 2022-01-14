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

        public ReponseDtos(string texte, string explication, bool istroll)
        {
            _Texte=texte;
            _Explication=explication;
            _isTroll = istroll;
        }

    }


}