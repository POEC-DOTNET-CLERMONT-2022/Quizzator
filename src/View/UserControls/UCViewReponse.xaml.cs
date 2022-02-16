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
    /// Logique d'interaction pour UCViewReponse.xaml
    /// </summary>
    public partial class UCViewReponse : UserControl
    {
        private int cpt = 1;
        public UCViewReponse()
        {
            InitializeComponent();
        }

        internal static readonly RoutedEvent gotoQuestionEvent = EventManager.RegisterRoutedEvent(
            "gotoNextQuestion", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(UCViewConnexion));

        internal event RoutedEventHandler gotoNextQuestion
        {
            add { AddHandler(gotoQuestionEvent, value); }
            remove { RemoveHandler(gotoQuestionEvent, value); }
        }

        internal void gotoNextQuestionClick(Object sender, RoutedEventArgs e)
        {
            cpt++;
            RaiseEvent(new RoutedEventArgs(gotoQuestionEvent));
        }

        internal static readonly RoutedEvent gotoMainPageEvent = EventManager.RegisterRoutedEvent(
            "gotoMainPageUCVR", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(UCViewQuestion));

        internal event RoutedEventHandler gotoMainPageUCVR
        {
            add { AddHandler(gotoMainPageEvent, value); }
            remove { RemoveHandler(gotoMainPageEvent, value); }
        }

        internal void gotoMainPageClick(Object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(gotoMainPageEvent));
        }
    }
}
