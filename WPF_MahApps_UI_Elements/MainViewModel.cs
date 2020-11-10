using System;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using WPF_MahApps_UI_Elements.UI_Elements_ViewModels;

namespace WPF_MahApps_UI_Elements
{
    public class MainViewModel : ViewModelBase
    {



        private TableViewModel _tableViewModel;
        public TableViewModel TableViewModel
        {
            get { return _tableViewModel; }
            set
            {
                _tableViewModel = value;
                OnPropertyChanged();
            }
        }

        private NavigationMenuViewModel _navigationMenuViewModel;
        public NavigationMenuViewModel NavigationMenuViewModel
        {
            get { return _navigationMenuViewModel; }
            set
            {
                _navigationMenuViewModel = value;
                OnPropertyChanged();
            }
        }


        private GraphViewModel _graphViewModel;
        public GraphViewModel GraphViewModel
        {
            get { return _graphViewModel; }
            set
            {
                _graphViewModel = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            TableViewModel = new TableViewModel();
            NavigationMenuViewModel = new NavigationMenuViewModel();
            GraphViewModel = new GraphViewModel();


        }




    }
}
