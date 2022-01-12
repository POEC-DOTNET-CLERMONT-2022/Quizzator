using System.Collections.Generic;

namespace Quizzator.Quizzator.Dtos
{


    public class ReponseDtos
    {
        private string _texte { get; set; }
        private string _explication { get; set; }
        private List<string> _lien { get; } = new List<string>();
        private bool _isTroll { get; set; }

        public ReponseDtos(string texte, string explication, bool istroll)
        {
            _texte=texte;
            _explication=explication;
            _isTroll = istroll;
        }

    }


}