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
        
        public bool IsTrool()
            { return _isTroll; }
        public void SetExplication(string explication)
        {
            if (explication != null || explication == String.Empty)
            {
                _explication = explication;
            }
            else
            {
                throw new Exception("Explication est vide!");
            }
        }
        
        public string GetExplication()
        {
            return _explication;
        }

        public void SetTexte(string texte)
        {
            if(texte != null || texte == String.Empty)
            {
                _texte = texte;
            }
            else
            {
                throw new Exception("Explication est vide!");
            }
        }
        public string GetTexte()
        {
            return _texte;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <exception cref="Exception"></exception>
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
