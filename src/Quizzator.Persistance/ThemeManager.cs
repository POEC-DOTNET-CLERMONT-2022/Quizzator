using AutoFixture;
using System.Collections.Generic;
using Quizzator.Quizzator.Models;

namespace Quizzator.Persistance
{
    public class ThemeManager : IThemeManager
    {
        
        private readonly Fixture _fixture = new Fixture();

        public IEnumerable<ThemeEx> GetAllTheme()
        {
            return _fixture.CreateMany<ThemeEx>(5);
        }

    }
}