using ServiceReference1;
using System.Windows;

namespace Quizzator.ThemeSelection
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public ThemeServiceClient ThemeServiceClient { get; }
        public App()
        {
            ThemeServiceClient = new ThemeServiceClient();
            
        }
    }
}
