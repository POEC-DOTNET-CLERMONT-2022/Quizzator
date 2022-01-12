using System.Collections.Generic;

namespace Quizzator.Quizzator.Dtos
{

        public class QuestionDtos
        {
            private int _id { get; set; }
            private string _texte { get; set; }
            private string _pathImage { get; set; }
            private List<ReponseDtos> _reponseList { get; set; }



            public QuestionDtos(int Id, string Texte, string PathImage, List<ReponseDtos> ReponseList)
            {
                _id = Id;
                _texte = Texte;
                _pathImage = PathImage;
                // TODO Verif ReponseList avant de la passer dans le constructeur
                _reponseList = ReponseList;
            }
        
        }
}