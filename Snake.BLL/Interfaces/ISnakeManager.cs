using Snake.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Interfaces
{
    public interface ISnakeManager
    {
        void СoordinatesChanger();
        RelayCommand MoveUpwardCommand { get; set; }
        RelayCommand MoveDownwardCommand { get; set; }
        RelayCommand MoveRightwardCommand { get; set; }
        RelayCommand MoveLeftwardCommand { get; set; }

    }
}
