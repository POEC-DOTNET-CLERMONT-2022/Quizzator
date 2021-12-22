using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Theme
{
    internal class ThemeEx
    {
        public string _name { get; set; }
        public List<Question> _question { get; set; }
        public string _imagePath { get; set; }

        public ThemeEx(string name, string imagePath)
        {
            _name = name;
            _imagePath = imagePath;
            _question = new List<Question>();
        }

        public ThemeEx(string name, string imagePath, List<Question> l) : this(name,imagePath)
        {
            _question = l;
        }

        public void AfficherList()
        {
            foreach (Question i in _question)
            {
                Console.WriteLine(" +++ "+i);
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

        public string SerializingTheme()
        {
            string output = JsonSerializer.Serialize(this, new JsonSerializerOptions {WriteIndented = true });
            return output;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetImagePath()
        {
            return _imagePath;
        }

        public List<Question> GetListQuestion()
        {
            return _question;
        }



    }
}
