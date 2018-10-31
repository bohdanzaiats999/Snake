using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.BLL.Models
{
    public class СoordinatesModel
    {
        public int X { get; set; }
        public int Y { get; set; }
        public СoordinatesModel(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
