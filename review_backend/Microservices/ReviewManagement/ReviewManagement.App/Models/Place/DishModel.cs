using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Models.Place
{
    public class DishModel
    {
        public Image Image { get; set; }

        public string Name { get; set; }

        public float Rate { get; set; }

        public float Price { get; set; }
    }
}
