using Snake.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.BLL.Managers
{
    public class SnakeManager
    {
        private SnakeModel snake;
        private PlayFieldModel playField;

        public SnakeManager()
        {
            playField = new PlayFieldModel();

            snake = new SnakeModel
            {
                Bodyes = new List<SnakeBodyPartModel>
                {
                    new SnakeBodyPartModel{Сoordinates = new СoordinatesModel(0,0), Direction = Direction.Upward},
                    new SnakeBodyPartModel{Сoordinates = new СoordinatesModel(0,1), Direction = Direction.Upward},
                    new SnakeBodyPartModel{Сoordinates = new СoordinatesModel(0,2), Direction = Direction.Upward}
                }
            };
        }
        public void СoordinatesChanger()
        {
            foreach (var body in snake.Bodyes)
            {
                var coordinate = body.Сoordinates;

                if (body.Direction == Direction.Upward)
                {
                    coordinate.X++;
                }
                else if (body.Direction == Direction.Downward)
                {
                    coordinate.X--;
                }
                else if (body.Direction == Direction.Leftward)
                {
                    coordinate.Y++;
                }
                else if (body.Direction == Direction.Rightward)
                {
                    coordinate.Y--;
                }
                body.Сoordinates = coordinate;
            }
        }
    }
}
