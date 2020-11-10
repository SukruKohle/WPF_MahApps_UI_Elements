using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WPF_MahApps_UI_Elements.Models;

namespace WPF_MahApps_UI_Elements.UI_Elements_ViewModels
{
    public class NavigationMenuViewModel
    {
        public ObservableCollection<NavigationItem> NavigationItems { get; }

        public NavigationMenuViewModel()
        {
            NavigationItems = new ObservableCollection<NavigationItem> {
                new NavigationItem { name = "Home" },
                new NavigationItem { name = "Products" }
            };

        }
    }
}
