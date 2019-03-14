using Snake.BLL.Models;
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
        SnakeModel GetSnake();
        void СoordinatesChanger();
        RelayCommand MoveUpwardCommand { get; }
        RelayCommand MoveDownwardCommand { get; }
        RelayCommand MoveRightwardCommand { get; }
        RelayCommand MoveLeftwardCommand { get; }

    }
}
