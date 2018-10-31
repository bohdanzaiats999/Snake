﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.BLL.Models
{
    public class PlayFieldModel
    {
        public int MinX { get; set; }
        public int MaxX { get; set; }
        public int MinY { get; set; }
        public int MaxY { get; set; }

        public PlayFieldModel()
        {
            this.MinX = 0;
            this.MaxX = 1000;
            this.MinY = 0;
            this.MaxY = 1000;
        }
    }
}
