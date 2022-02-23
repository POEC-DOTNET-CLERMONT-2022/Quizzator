using AutoFixture;
using Quizzator.Quizzator.Models;
using RequestsAPI;
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

namespace View.UserControls
{
    /// <summary>
    /// Logique d'interaction pour UCViewMainPage.xaml
    /// </summary>
    public partial class UCViewMainPage : UserControl
    {

        Fixture fixture = new Fixture();
        internal List<ThemeEx> ListThem;
        public UCViewMainPage()
        {
            InitializeComponent();

            ListThem = fixture.CreateMany<ThemeEx>(10).ToList();
            ListTheme.ItemsSource = ListThem;
            
        }

        internal static readonly RoutedEvent gotoViewQuestionEvent = EventManager.RegisterRoutedEvent(
            "gotoViewQuestion", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(UCViewQuestion));

        internal event RoutedEventHandler gotoViewQuestion
        {
            add { AddHandler(gotoViewQuestionEvent, value); }
            remove { RemoveHandler(gotoViewQuestionEvent, value); }
        }

        internal void gotoViewQuestionClick(Object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(gotoViewQuestionEvent));
        }


        internal static readonly RoutedEvent gotoScoreEvent = EventManager.RegisterRoutedEvent(
            "gotoViewScore", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(UCViewQuestion));

        internal event RoutedEventHandler gotoViewScore
        {
            add { AddHandler(gotoScoreEvent, value); }
            remove { RemoveHandler(gotoScoreEvent, value); }
        }

        internal void gotoViewScoreClick(Object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(gotoScoreEvent));
        }

    }
}
