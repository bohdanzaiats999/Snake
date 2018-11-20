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
            Сoordinates.X = coordinates.Next(Properties.Settings.Default.MinXFieldLength, Properties.Settings.Default.MaxXFieldLength);
            Сoordinates.Y = coordinates.Next(Properties.Settings.Default.MinYFieldLength, Properties.Settings.Default.MaxYFieldLength);
        }
        public СoordinatesModel Сoordinates { get; set; }
    }
}
