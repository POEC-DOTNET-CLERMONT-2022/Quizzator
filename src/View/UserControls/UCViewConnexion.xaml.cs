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
    /// Logique d'interaction pour UCViewConnexion.xaml
    /// </summary>
    public partial class UCViewConnexion : UserControl
    {
        public UCViewConnexion()
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
            "gotoMainPage", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(UCViewConnexion));

        internal event RoutedEventHandler gotoMainPage
        {
            add { AddHandler(gotoMainPageEvent, value); }
            remove { RemoveHandler(gotoMainPageEvent, value); }
        }

        internal void gotoMainPageClick(Object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(gotoMainPageEvent));
        }


        //Event go to SignUp
        internal static readonly RoutedEvent gotoViewSignUpEvent = EventManager.RegisterRoutedEvent("gotoViewSignUp", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(UCViewConnexion));

        internal event RoutedEventHandler gotoViewSignUp
        {
            add { AddHandler(gotoViewSignUpEvent, value); }
            remove { RemoveHandler(gotoViewSignUpEvent, value); }
        }

        internal void gotoViewSignUpClick(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(gotoViewSignUpEvent));
        }
    }
}
