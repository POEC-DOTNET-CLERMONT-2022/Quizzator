using System;
using System.Collections.Generic;
using System.Linq;
using Quizzator.Entity;

namespace Quizzator.Persistance
{
    public class ThemeManager
    {
        private readonly QuizContext Context;
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
    
    }
}