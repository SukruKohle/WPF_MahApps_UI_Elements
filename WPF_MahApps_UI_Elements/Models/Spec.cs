using System.Collections.Generic;

namespace WPF_MahApps_UI_Elements.Models
{
    public class Spec
    {
        public int Id { get; set; }
        public string name { get; set; }
        public List<Ingredient> ingredients { get; set; }
    }
}
