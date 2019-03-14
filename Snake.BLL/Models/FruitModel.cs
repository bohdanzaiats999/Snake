using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.BLL.Models
{
    public class FruitModel
    {
        public FruitModel()
        {
            Random coordinates = new Random();
            Сoordinates = new СoordinatesModel()
            {
                X = coordinates.Next(0, Properties.Settings.Default.MaxXFieldLength),
                Y = coordinates.Next(0, Properties.Settings.Default.MaxYFieldLength)
            };
        }
        public СoordinatesModel Сoordinates { get; set; }
    }
}
