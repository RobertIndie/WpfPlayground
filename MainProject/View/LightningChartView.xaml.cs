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

using Arction.Wpf.SemibindableCharting;

namespace RE.MainProject.View
{
    /// <summary>
    /// LightningChartView.xaml 的交互逻辑
    /// </summary>
    public partial class LightningChartView : Window
    {
        public LightningChartView()
        {
            InitializeComponent();
        }

        public SeriesPoint[] testData
        {
            get { return (SeriesPoint[])GetValue(testDataProperty); }
            set { SetValue(testDataProperty, value); }
        }

        // Using a DependencyProperty as the backing store for testData.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty testDataProperty =
            DependencyProperty.Register("testData", typeof(SeriesPoint[]), typeof(LightningChartView), new PropertyMetadata());

        private void window_Loaded(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Load window");
            const int length = 10000;
            SeriesPoint[] seriesPoints = new SeriesPoint[length];
            for (int i = 0; i < length; i++)
            {
                seriesPoints[i].X = i;
                seriesPoints[i].Y = i * Math.Sin(i);
            }
            testData=seriesPoints;
        }
    }
}
