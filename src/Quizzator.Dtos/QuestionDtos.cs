using System.Collections.Generic;

namespace Quizzator.Quizzator.Dtos
{

        public class QuestionDtos
        {
            private int _Id { get; set; }
            private string _Texte { get; set; }
            private string _ImagePath { get; set; }
            private List<ReponseDtos> _ReponseList { get; set; }



            public QuestionDtos(int Id, string Texte, string ImagePath, List<ReponseDtos> ReponseList)
            {
                _Id = Id;
                _Texte = Texte;
                _ImagePath = ImagePath;
                // TODO Verif ReponseList avant de la passer dans le constructeur
                _ReponseList = ReponseList;
            }
        
        }
}