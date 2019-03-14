using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Snake.BLL.Managers;
using Snake.BLL.Models;
using Snake.Interfaces;

namespace Snake.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ISnakeManager snake;
        public MainWindow()
        {
            InitializeComponent();
            snake = new SnakeManager();

            foreach (var body in snake.GetSnake().Bodyes)
            {
                PaintSnake(body.Сoordinates);
            }

            for (int i = 0; i < 5; i++)
            {
                snake.СoordinatesChanger();
            }
        }
        // Paint snake body part
        private void PaintSnake(СoordinatesModel coordinates)
        {
            Image image = new Image
            {
                Source = new BitmapImage(new Uri(Properties.Settings.Default.SnakeBodyImage, UriKind.Relative)),
                Height = 10,
                Width = 10
            };
            Canvas.SetTop(image, coordinates.Y);
            Canvas.SetLeft(image, coordinates.X);
            SnakeCanvas.Children.Add(image);

        }
    }
}
