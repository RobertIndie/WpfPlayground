using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Threading;
using Arction.Wpf.SemibindableCharting;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace RE.MainProject.View
{
    /// <summary>
    /// LightningChartView.xaml 的交互逻辑
    /// </summary>
    public partial class LightningChartView : Window
    {
        public LightningChartView()
        {
            InitializeComponent();//最好别在这写与WPF无关的代码，否则报错都不知道是啥错。请移步到windwo_Loaded方法
            /*DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Tick += (sender, e) => {
                List<SeriesPoint> list = new List<SeriesPoint>(testData);
                list.Add(new SeriesPoint()
                {
                    X = list[list.Count() - 1].X + 1,
                    Y = (list[list.Count() - 1].X + 1) * Math.Sin(list[list.Count() - 1].X + 1)
                });
                testData = list.ToArray();
            };
            timer.Start();*/
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
            LoadExcel();
        }

        private void GenData()
        {
            const int length = 10000000;
            SeriesPoint[] seriesPoints = new SeriesPoint[length];
            for (int i = 0; i < length; i++)
            {
                seriesPoints[i].X = i;
                seriesPoints[i].Y = i * Math.Sin(i);
            }
            testData = seriesPoints;
        }

        private void LoadExcel()
        {
            HSSFWorkbook hSSFWorkbook;//暂时不支持导入xlsx
            using (FileStream file = new FileStream("test.xls", FileMode.Open, FileAccess.Read,FileShare.ReadWrite))
            {
                hSSFWorkbook = new HSSFWorkbook(file);
            }
            var sheet = hSSFWorkbook.GetSheetAt(0);
            var rows = sheet.GetRowEnumerator();
            List<SeriesPoint> points = new List<SeriesPoint>();
            int id = 0;
            while(rows.MoveNext())
            {
                HSSFRow row = rows.Current as HSSFRow;

                //for(int i=0;i<row.LastCellNum;i++)
                //{
                //    var cell = row.GetCell(i);
                //    Console.WriteLine(cell.StringCellValue);
                //}

                points.Add(new SeriesPoint(id++, row.GetCell(1).NumericCellValue));
            }
            testData = points.ToArray();
        }
    }
}
