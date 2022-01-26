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
    /// Logique d'interaction pour UCViewQuestion.xaml
    /// </summary>
    public partial class UCViewQuestion : UserControl
    {
        public UCViewQuestion()
        {
            InitializeComponent();
        }

        internal static readonly RoutedEvent gotoMainPageEvent = EventManager.RegisterRoutedEvent(
            "gotoMainPage", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(UCViewQuestion));

        internal event RoutedEventHandler gotoMainPage
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
