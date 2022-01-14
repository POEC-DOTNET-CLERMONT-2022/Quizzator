using System;
using System.Collections.Generic;

namespace Quizzator.Quizzator.Models
{
    public sealed class Reponse
    {
        #region Init
        private string _Texte { get; set; }
        private string _Explication { get; set; }
        private List<string> _Lien { get; } =  new List<string>();
        private string _ImagePath { get; set; } 
        private bool _isTroll { get; set; }

        public Reponse(string texte, string explication, bool istroll)
        {
            SetTexte(texte);
            SetExplication(explication);
            _isTroll = istroll;
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="explication"></param>
        /// <exception cref="Exception"></exception>
        public void SetExplication(string explication)
        {
            if (explication != null || explication == string.Empty)
            {
                _Explication = explication;
            }
            else
            {
                throw new Exception("Explication est vide!");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="texte"></param>
        /// <exception cref="Exception"></exception>
        public void SetTexte(string texte)
        {
            if (texte != null || texte == string.Empty)
            {
                _Texte = texte;
            }
            else
            {
                throw new Exception("Explication est vide!");
            }
        }
        public string GetTexte()
        {
            return _Texte;
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
                if (_Lien.Count < 2)
                {
                    _Lien.Add(link);
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
