using AutoFixture;
using Quizzator.Quizzator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using View;
using View.UserControls;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal UCViewConnexion UCViewConnexion { get; set; } = new UCViewConnexion();
        internal UCViewMainPage UCViewMainPage { get; set; } = new UCViewMainPage();
        internal UCViewSignUp UCViewSignUp { get; set; } = new UCViewSignUp();
        internal UCViewQuestion UCViewQuestion { get; set; } = new UCViewQuestion();
        //Fixture fixture = new Fixture();
        //internal List<ThemeEx> ListTheme = new List<ThemeEx>();
        public MainWindow()
        {
            InitializeComponent();
            ContentControl.Content = UCViewConnexion;

            UCViewConnexion.gotoViewSignUp += gotoViewSignUp;
            UCViewConnexion.gotoMainPage += gotoMainPage;
            UCViewSignUp.gotoViewConnexion += gotoViewConnexion;
            UCViewSignUp.gotoMainPage2 += gotoMainPage;
            UCViewMainPage.gotoViewQuestion += gotoViewQuestion;
            UCViewQuestion.gotoMainPage += gotoMainPage;


           /* ListTheme = fixture.CreateMany<ThemeEx>(15).ToList();
            DataContext = ListTheme;*/

        }

        private void gotoViewConnexion(object sender, RoutedEventArgs e)
        {
            ContentControl.Content = UCViewConnexion;
        }

        private void gotoMainPage(object sender, RoutedEventArgs e)
        {
            ContentControl.Content = UCViewMainPage;
        }

        private void gotoViewSignUp(object sender, RoutedEventArgs e)
        {
            ContentControl.Content = UCViewSignUp;
        }

        private void gotoViewQuestion(object sender, RoutedEventArgs e)
        {
            ContentControl.Content = UCViewQuestion;
        }



    }
}
