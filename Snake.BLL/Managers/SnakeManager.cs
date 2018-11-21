using Snake.BLL.Models;
using Snake.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Snake.BLL.Managers
{
    public class SnakeManager : INotifyPropertyChanged
    {
        private SnakeModel snake;
        private PlayFieldModel playField;
        private FruitModel fruit;
        private RelayCommand moveUpwardCommand;
        private RelayCommand moveDownwardCommand;
        private RelayCommand moveLeftwardCommand;
        private RelayCommand moveRightwardCommand;
        public event PropertyChangedEventHandler PropertyChanged;

        public SnakeManager()
        {
            playField = new PlayFieldModel();
            fruit = new FruitModel();
            snake = new SnakeModel { Bodyes = new LinkedList<SnakeBodyPartModel>() };
            snake.Bodyes.AddFirst(new SnakeBodyPartModel { Сoordinates = new СoordinatesModel(20, 20), Direction = Direction.Upward });
            snake.Bodyes.AddFirst(new SnakeBodyPartModel { Сoordinates = new СoordinatesModel(40, 40), Direction = Direction.Upward });
            snake.Bodyes.AddFirst(new SnakeBodyPartModel { Сoordinates = new СoordinatesModel(60, 60), Direction = Direction.Upward });
        }

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));

            }
        }

        public SnakeModel GetSnake()
        {
            return snake;
        }

        public void СoordinatesChanger()
        {
            var first = snake.Bodyes.First();
            // Coordinates X++
            if (snake.Bodyes.First().Direction == Direction.Upward &&
                first.Сoordinates.X + Properties.Settings.Default.Step < Properties.Settings.Default.MaxXFieldLength)
            {
                first.Сoordinates.X += Properties.Settings.Default.Step;
            }

            // Coordinates Y++
            else if (snake.Bodyes.First().Direction == Direction.Leftward
                && first.Сoordinates.Y + Properties.Settings.Default.Step < Properties.Settings.Default.MaxYFieldLength)
            {
                first.Сoordinates.Y += Properties.Settings.Default.Step;
            }
            // Coordinates X--
            else if (snake.Bodyes.First().Direction == Direction.Downward
                && first.Сoordinates.X - Properties.Settings.Default.Step > Properties.Settings.Default.MinXFieldLength)
            {
                first.Сoordinates.X -= Properties.Settings.Default.Step;
            }
            // Coordinates Y--
            else if (snake.Bodyes.First().Direction == Direction.Rightward
                && first.Сoordinates.Y - Properties.Settings.Default.Step > Properties.Settings.Default.MinYFieldLength)
            {
                first.Сoordinates.Y -= Properties.Settings.Default.Step;
            }
            else
            {
                throw new Exception("Outside play field");
            }
            // Create new first body part
            snake.Bodyes.AddBefore(snake.Bodyes.Find(snake.Bodyes.First()), first);

            if (first.Сoordinates.X != fruit.Сoordinates.X && 
                first.Сoordinates.Y != fruit.Сoordinates.Y)
            {
                snake.Bodyes.RemoveLast();
            }
        }

        public RelayCommand MoveUpwardCommand
        {
            get
            {
                return moveUpwardCommand ?? (moveUpwardCommand = new RelayCommand(obj =>
                {
                    try
                    {
                        snake.Bodyes.First().Direction = Direction.Upward;
                        СoordinatesChanger();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }));
            }
        }

        public RelayCommand MoveDownwardCommand
        {
            get
            {
                return moveDownwardCommand ?? (moveDownwardCommand = new RelayCommand(obj =>
                {
                    try
                    {
                        snake.Bodyes.First().Direction = Direction.Downward;
                        СoordinatesChanger();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }));
            }
        }

        public RelayCommand MoveRightwardCommand
        {
            get
            {
                return moveRightwardCommand ?? (moveRightwardCommand = new RelayCommand(obj =>
                {
                    try
                    {
                        snake.Bodyes.First().Direction = Direction.Rightward;
                        СoordinatesChanger();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }));
            }
        }
        public RelayCommand MoveLeftwardCommand
        {
            get
            {
                return moveLeftwardCommand ?? (moveLeftwardCommand = new RelayCommand(obj =>
                {
                    try
                    {
                        snake.Bodyes.First().Direction = Direction.Leftward;
                        СoordinatesChanger();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }));
            }
        }
    }
}
