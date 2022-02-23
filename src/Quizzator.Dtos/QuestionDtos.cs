using System;
using System.Collections.Generic;

namespace Quizzator.Quizzator.Dtos
{

        public class QuestionDtos
        {
        public Guid Id { get; set; }
        public string Texte { get; set; }
        public string ImagePath { get; set; }
        public ICollection<ReponseDtos> ReponseList { get; set; }

        public QuestionDtos()
        {

        }



        public QuestionDtos(Guid id, string texte, string imagePath, ICollection<ReponseDtos> reponseList)
        {
            Id = id;
            Texte = texte;
            ImagePath = imagePath;
            // TODO Verif ReponseList avant de la passer dans le constructeur
            ReponseList = reponseList;
        }
        
    }
}