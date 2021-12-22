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
        
        /// <summary>
        /// Retourne si la réponse est une réponse valide ou non
        /// </summary>
        /// <returns>bool </returns>
        public bool IsTrool()
            { return _isTroll; }
        /// <summary>
        /// Détermine le texte d'explicatio  accompagnant la réponse
        /// </summary>
        /// <param name="explication">Recoit l'explication correspondant à la réponse</param>
        /// <exception cref="Exception">Raise une Exception si l'explication est vide</exception>
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
        /// <summary>
        /// Retourne 
        /// </summary>
        /// <returns> Retourne un string contenant l'explication de la Réponse</returns>
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
