using ServiceReference1;
using System.Windows;

namespace ThemeSelection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IThemeService ThemeServiceClient { get; }
        public MainWindow()
        {
            if (Application.Current is App app)
            {
                ThemeServiceClient = app.ThemeServiceClient;
            }
            InitializeComponent();
            // NomTheme.IemsSource = ThemeServiceClient.GetData(12);
        }
    }
}
