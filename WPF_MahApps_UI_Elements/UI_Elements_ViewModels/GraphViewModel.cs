using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_MahApps_UI_Elements.UI_Elements_ViewModels
{
    public class GraphViewModel
    {
        public SeriesCollection columnSeriesCollection { get; set; }
        public string[] columnLabels { get; set; }
        public Func<double, string> columnFormatter { get; set; }

        public SeriesCollection pieSeriesCollection { get; set; }

        public GraphViewModel()
        {
            columnSeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "2019",
                    Values = new ChartValues<double> { 10, 50, 39 }
                },
                new ColumnSeries
                {
                    Title = "2020",
                    Values = new ChartValues<double> { 20, 40, 20 }
                }
            };

            columnLabels = new[] { "Product A", "Product B", "Product C", "Product D" };
            columnFormatter = value => value.ToString("N");
           
            pieSeriesCollection = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Product A",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(8) },
                    DataLabels = false,                    
                },
                new PieSeries
                {
                    Title = "Product B",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(6) },
                    DataLabels = false
                },
                new PieSeries
                {
                    Title = "Product C",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(10) },
                    DataLabels = false
                },
            };
        }
    }
}
