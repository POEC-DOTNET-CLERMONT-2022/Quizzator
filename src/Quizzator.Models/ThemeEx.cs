using System;
using System.Collections.Generic;

namespace Quizzator.Quizzator.Models
{
    public class ThemeEx
    {

        #region Init
        public string _Name { get; }
        public List<Question> _Question;
        public string _ImagePath;
        public bool IsVisible;

        public ThemeEx(string name, string imagePath)
        {
            _Name = name;
            _ImagePath = imagePath;
        }
        #endregion
        #region Getter & Setter
        public string getName()
        {
            return _Name;
        }
        /*public void setName(string name)
        {
            _Name = name;
        }*/
        public string getImagePath() 
        {
            return _ImagePath;
        }
        public void setImagePath(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath))
            {
                _ImagePath = imagePath;
            }
            else
            {
                throw new Exception("L'explication est vide!");
            }
        }
        public bool isVisible() { return IsVisible; }
        public void setVisibile() { IsVisible = true; }
        public void DisableVisibility() { IsVisible = false; }
        #endregion
        public void AddQuestion(Question UneQuestion)
        {
            if (_Question.Count ==9)
            {
                setVisibile();
            }
            _Question.Add(UneQuestion);
        }

    }
}
