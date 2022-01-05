using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzator.Quizzator.Models
{
    public class Question
    {
        private int _id;
        private string _texte;
        private string _pathImage;
        private List<Reponse> _reponseList = new List<Reponse>();
    }
}
