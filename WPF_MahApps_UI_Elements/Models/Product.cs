using System.Collections.Generic;

namespace WPF_MahApps_UI_Elements.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public List<Spec> specs { get; set; }
    }
}
