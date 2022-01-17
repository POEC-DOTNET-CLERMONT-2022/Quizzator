﻿using System;
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
    /// Logique d'interaction pour UCViewSignUp.xaml
    /// </summary>
    public partial class UCViewSignUp : UserControl
    {
        public UCViewSignUp()
        {
            InitializeComponent();
        }

        public void ResetDefaultText(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= ResetDefaultText;
        }

        //Event go to MainPage
        internal static readonly RoutedEvent gotoMainPageEvent = EventManager.RegisterRoutedEvent(
            "gotoMainPage2", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(UCViewConnexion));

        internal event RoutedEventHandler gotoMainPage2
        {
            add { AddHandler(gotoMainPageEvent, value); }
            remove { RemoveHandler(gotoMainPageEvent, value); }
        }

        internal void gotoMainPageClick(Object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(gotoMainPageEvent));
        }

        internal static readonly RoutedEvent gotoViewConnexionEvent = EventManager.RegisterRoutedEvent(
            "gotoViewConnexion", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(UCViewConnexion));

        internal event RoutedEventHandler gotoViewConnexion
        {
            add { AddHandler(gotoViewConnexionEvent, value); }
            remove { RemoveHandler(gotoViewConnexionEvent, value); }
        }

        internal void gotoViewConnexionClick(Object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(gotoViewConnexionEvent));
        }
    }
}
