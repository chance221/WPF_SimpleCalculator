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
using System.Windows.Shapes;

namespace Wpf_MySimpleCalculator
{
    /// <summary>
    /// Interaction logic for SolutionWindow.xaml
    /// </summary>
    public partial class SolutionWindow : Window
    {
        public SolutionWindow(double conversion)
        {
            InitializeComponent();
            //this is where you send the actual conversion value. NEed to do this with dropdown boxes
            //Label_Volume.Content = conversion;
        }

        private void Button_CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
