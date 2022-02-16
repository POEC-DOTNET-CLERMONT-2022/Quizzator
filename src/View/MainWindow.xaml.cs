﻿using AutoFixture;
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
        internal UCViewReponse UCViewReponse { get; set; } = new UCViewReponse();
        internal UCViewScore UCViewScore { get; set; } = new UCViewScore();
        internal UCViewProfile UCViewProfile { get; set; } = new UCViewProfile();
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
            UCViewMainPage.gotoViewScore += gotoViewScore;
            UCViewQuestion.gotoMainPage += gotoMainPage;
            UCViewQuestion.gotoReponse += gotoReponse;
            UCViewReponse.gotoNextQuestion += gotoViewQuestion;
            UCViewReponse.gotoMainPageUCVR += gotoMainPage;

        }

        private void gotoViewScore(object sender, RoutedEventArgs e)
        {
            ContentControl.Content = UCViewScore;
        }

        private void gotoReponse(object sender, RoutedEventArgs e)
        {
            ContentControl.Content = UCViewReponse;
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
