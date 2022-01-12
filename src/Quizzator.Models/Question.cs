using System;
using System.Collections.Generic;

namespace Quizzator.Quizzator.Models
{
    public sealed class Question
    {
        private int _id { get; set; }
        private string _texte { get; set; }
        private string _pathImage { get; set; }
       private List<Reponse> _reponseList { get; set; }
        


        public Question(int Id, string Texte, string PathImage, List<Reponse> ReponseList)
        {
            _id = Id;
            _texte = Texte;
            _pathImage = PathImage;
            // TODO Verif ReponseList avant de la passer dans le constructeur
            _reponseList = VerifReponse(ReponseList);
        }

        private List<Reponse> VerifReponse(List<Reponse> reponseList)
        {
            throw new NotImplementedException();
        }
    }
}
