using System;
using System.Collections.Generic;
using System.Linq;

namespace Quizzator.Quizzator.Models
{
    public sealed class Reponse
    {
        #region Init
        private string _Texte;
        private string _Explication;
        private List<string> _Lien;
        private string _ImagePath;
        private bool _isTroll;
        private Reponse(string texte, string explication, string ImagePath)
        {
            setTexte(texte);
            setExplication(explication);
            setImage(ImagePath);

        }
        public Reponse(string texte, string explication, string ImagePath, int istroll) : this(texte, explication, ImagePath)
        {
            if (istroll == 0)
            {
                setisTroll(false);
            }
            else
            {
                setisTroll(true);
            }
        }
        public Reponse(string texte, string explication, string ImagePath, bool isTroll) :this(texte, explication, ImagePath)
        {
            setisTroll(isTroll);
        }
        #endregion
        #region Getter & Setter
        public string getTexte()
        {
            return _Texte;
        }
        public void setTexte(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                _Texte = value;
            }
            else
            {
                throw new Exception("Texte est vide!");
            }

        }
        public string getExplication()
        {
            return _Explication;

        }
        public void setExplication(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                _Explication = value;
            }
            else
            {
                throw new Exception("L'explication est vide!");
            }
        }
        public List<string> getLiens()
        {
            return _Lien;
        }
        public string getImage() { return _ImagePath; }
        public void setImage(string ImagePath)
        {
            _ImagePath = ImagePath;
        }
        public bool isTroll()
        {
            return _isTroll;
        }
        public void setisTroll(bool value)
        {
            _isTroll = value;
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <exception cref="Exception"></exception>
        public void AddLinkInList(string link)
        {
            if(_Lien==null && !_Lien.Any()) { _Lien = new List<string>(); }
            if (_Lien.Contains(link)) 
            { 
                throw new Exception("Lien déjà présent"); 
            }
            else
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
}
