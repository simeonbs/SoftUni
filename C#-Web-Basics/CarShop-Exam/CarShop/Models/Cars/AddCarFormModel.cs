using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Models.Cars
{
    public class AddCarFormModel
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Image { get; set; }
        public string PlateNumber { get; set; }
    }
}
