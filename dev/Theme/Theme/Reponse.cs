using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Theme
{
    internal class Reponse
    {
        private string _texte;
        private string _explication;
        private List<string> _lien = new List<string>();
        private bool _isTroll;

        public Reponse(string texte, string explication, bool istroll)
        {
            _texte = texte;
            _explication = explication;
            _isTroll = istroll;
        }

        public void AddLinkInList(string link)
        {
            if (Uri.IsWellFormedUriString(link, UriKind.Absolute))
            {
                if(_lien.Count < 2)
                {
                    _lien.Add(link);
                }
                else
                {
                    throw new Exception("Deja 3 liens presents");
                }   
            }
            else
            {
                throw new Exception("Erreur saisie lien");
            }
        }
    }
}
