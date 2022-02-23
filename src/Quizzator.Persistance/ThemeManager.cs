using System;
using System.Collections.Generic;
using System.Linq;
using Quizzator.Entity;

namespace Quizzator.Persistance
{
    public class ThemeManager
    {
        private QuizContext Context { get; }
        public ThemeManager (QuizContext QuizContext)
        {
            this.Context = QuizContext;    
        }

        public ThemeManager()
        {
        }

        public IEnumerable<ThemeExEntity>GetAllTheme()
        {    
            return Context.Set<ThemeExEntity>().ToList();
        }
        public ThemeExEntity Get (Guid id)
        {
            return Context.Set<ThemeExEntity>().Find(id);
        }

        /*public IEnumerable<ThemeExEntity> GetThemeByName(string name)
        {
            return Context.Set<ThemeExEntity>().ToList();
        }*/

        public int CreateTheme(ThemeExEntity theme)
        {
            Context.Add(theme);
            int i =  Context.SaveChanges();

            return i;
            
        }

        public int DeleteTheme(Guid guid)
        {
            var theme = Get(guid);

            Context.Remove(theme);

            return Context.SaveChanges();
        }


    }
}