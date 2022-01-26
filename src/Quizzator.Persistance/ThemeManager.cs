using System;
using System.Collections.Generic;
using System.Linq;
using Quizzator.Entity;

namespace Quizzator.Persistance
{
    public class ThemeManager
    {
        private readonly QuizContext _context;
        public ThemeManager (QuizContext QuizContext)
        {
            this._context = QuizContext;    
        }

        public ThemeManager()
        {
        }

        public IEnumerable<ThemeExEntity>GetAllTheme()
        {
            var query = _context.ThemeEx.AsEnumerable();
            return query;
        }
        public ThemeExEntity Get (Guid id)
        {
            return _context.Set<ThemeExEntity>().Find(id);
        }
    
    }
}