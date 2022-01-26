using System;
using System.Collections.Generic;

namespace Quizzator.Quizzator.Models
{
    public sealed class Question
    {
        #region Init
        private int _Id;
        private string _Texte;
        private string _ImagePath;
        private List<Reponse> _ReponseList;
        #endregion
        #region Getter & Setter
        public Question(string Texte, string PathImage, List<Reponse> ReponseList)
        {
            setTexte(Texte);
            setImagePath(PathImage);
            // TODO Verif ReponseList avant de la passer dans le constructeur
            //_ReponseList = VerifReponse(ReponseList);
            _ReponseList= new List<Reponse>();
        }
        public Question(int Id, string Texte, string PathImage, List<Reponse> ReponseList) : this(Texte, PathImage, ReponseList)
        {
            setId(Id);;
        }

        public void setId(int Id)
        {
            _Id=Id;
        }
        public int getId()
        {
            return _Id;
        }

        public void setTexte(string Texte)
        {
            if (!string.IsNullOrEmpty(Texte))
            {
                _Texte=Texte;
            }
            else
            {
                throw new Exception("Texte is Empty");
            }
        }
        public string getTexte() {  return _Texte; }
        public void setImagePath(string Path)
        {
            if (!string.IsNullOrEmpty(Path))
            {
                _ImagePath = Path;
            }
            else
            {
                throw new Exception("Path is Empty");
            }
        }
        public string getImagePath() { return _ImagePath; }
        public void ajoutReponse(Reponse uneReponse)
        {
            if (uneReponse != null)
            {
                _ReponseList.Add(uneReponse);
            }
        }
        public List<Reponse> getReponses()
        {
            return _ReponseList;
        }
        #endregion

        private List<Reponse> VerifReponse(List<Reponse> reponseList)
        {
            throw new NotImplementedException();
        }
    }
}
