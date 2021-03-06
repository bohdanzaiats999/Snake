﻿using Snake.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Snake.ViewModel
{
    public class SnakeViewModel
    {
        ISnakeManager snakeService;
        public event PropertyChangedEventHandler PropertyChanged;
        public SnakeViewModel(ISnakeManager snakeService)
        {
            this.snakeService = snakeService;
        }
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
