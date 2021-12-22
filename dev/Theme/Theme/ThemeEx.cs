using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme
{
    internal class ThemeEx
    {
        private string _name;
        private List<Question> _question;
        private string _imagePath;

        public ThemeEx(string name, string imagePath)
        {
            _name = name;
            _imagePath = imagePath;
            _question = new List<Question>();
        }

        public ThemeEx(string name, string imagePath, List<Question> l) : this(name, imagePath)
        {
            _question = l;
        }

        public void AfficherList()
        {
            foreach (Question i in _question)
            {
                Console.WriteLine(" +++ " + i);
            }
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetImagePath(string imPath)
        {
            _imagePath = imPath;
        }

        public void SetList(List<Question> l)
        {
            _question = l;
        }

    }
}
