﻿using Snake.BLL.Models;
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
        private RelayCommand moveUpwardCommand;
        private RelayCommand moveDownwardCommand;
        private RelayCommand moveLeftwardCommand;
        private RelayCommand moveRightwardCommand;
        public event PropertyChangedEventHandler PropertyChanged;

        public SnakeManager()
        {
            playField = new PlayFieldModel();

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
        public void СoordinatesChanger()
        {
            var last = snake.Bodyes.Last();
            if (snake.Bodyes.First().Direction == Direction.Upward)
            {
                last.Сoordinates.X = +20;
            }
            else if (snake.Bodyes.Last().Direction == Direction.Downward)
            {
                last.Сoordinates.X = -20;                
            }
            else if (snake.Bodyes.Last().Direction == Direction.Leftward)
            {
                last.Сoordinates.Y = +20;                
            }
            else if (snake.Bodyes.Last().Direction == Direction.Rightward)
            {
                last.Сoordinates.X = +20;
            }
            snake.Bodyes.AddBefore(snake.Bodyes.Find(snake.Bodyes.First()), last);
            snake.Bodyes.RemoveLast();
        }
        public RelayCommand MoveUpwardCommand
        {
            get
            {
                return moveUpwardCommand ?? (moveUpwardCommand = new RelayCommand(obj =>
                {
                    try
                    {
                        snake.Bodyes.Last().Direction = Direction.Upward;
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
                        snake.Bodyes.Last().Direction = Direction.Downward;
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
                        snake.Bodyes.Last().Direction = Direction.Rightward;
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
                        snake.Bodyes.Last().Direction = Direction.Leftward;
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
