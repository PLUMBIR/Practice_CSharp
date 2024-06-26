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


namespace zad3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double step = double.Parse(txtStep.Text);
            LineSeries lineSeries = new LineSeries();
            List<KeyValuePair<double, double>> points = new List<KeyValuePair<double, double>>();
            for (double x = -10; x <= 10; x += step)
            {
                double y = Math.Sin(x); // функция y=x
                points.Add(new KeyValuePair<double, double>(x, y));
            }
            lineSeries.DependentValuePath = "Value";
            lineSeries.IndependentValuePath = "Key";
            lineSeries.ItemsSource = points;
            chart.Series.Clear();
            chart.Series.Add(lineSeries);
        }
    }
}
