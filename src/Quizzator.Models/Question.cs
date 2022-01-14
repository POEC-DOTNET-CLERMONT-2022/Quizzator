using System;
using System.Collections.Generic;

namespace Quizzator.Quizzator.Models
{
    public sealed class Question
    {
        private int _Id { get; set; }
        private string _Texte { get; set; }
        private string ImagePath { get; set; }
       private List<Reponse> _ReponseList { get; set; }
        


        public Question(int Id, string Texte, string PathImage, List<Reponse> ReponseList)
        {
            _Id = Id;
            _Texte = Texte;
            ImagePath = PathImage;
            // TODO Verif ReponseList avant de la passer dans le constructeur
            _ReponseList = VerifReponse(ReponseList);
        }

        private List<Reponse> VerifReponse(List<Reponse> reponseList)
        {
            throw new NotImplementedException();
        }
    }
}
