﻿using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace WpfApp1908401.Views
{
  /// <summary>
  /// Interaction logic for Settings.xaml
  /// </summary>
  public partial class Settings : Window
  {
    public Settings(double WindowLeft, double WindowTop)
    {
      InitializeComponent();

      DataContext = App.Settings;

      ServerNameTextBox.Focus();

      // Window position
      Left = WindowLeft + 20;
      Top = WindowTop + 20;
    }

    private void SaveButton_Click(object sender, RoutedEventArgs e)
    {
      App.Settings.Save();
      Close();
    }
  }
}
