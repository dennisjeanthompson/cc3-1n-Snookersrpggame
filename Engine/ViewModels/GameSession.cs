using Engine.Factories;
using Engine.Models;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession : INotifyPropertyChanged
    {
        private Location? _currentLocation;
        public  Player CurrentPlayer { get; set; }
        public Location? CurrentLocation {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;

                OnPropertyChanged("CurrentLocation");
                OnPropertyChanged("HasLocationToNorth");
                OnPropertyChanged("HasLocationToSouth");
                OnPropertyChanged("HasLocationToWest");
                OnPropertyChanged("HasLocationToEast");
            }
        }

        public World CurrentWorld { get; set; }
        public bool HasLocationToNorth => CurrentLocation != null && CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null;
        public bool HasLocationToSouth => CurrentLocation != null && CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null;

        public bool HasLocationToEast => CurrentLocation != null && CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null;

        public bool HasLocationToWest => CurrentLocation != null && CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null;
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Anromeda";
            CurrentPlayer.CharacterClass = "Warrior";
            CurrentPlayer.HitPoints = 24000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Gold = 1000;
            CurrentPlayer.Level = 1;


            WorldFactory worldfactory = new WorldFactory();
            CurrentWorld = worldfactory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, -1);
     
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public void MoveNorth()
        {
            if (CurrentLocation != null)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
            }
        }
        public void MoveSouth()
        {
            if (CurrentLocation != null)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
            }
        }
        public void MoveWest()
        {
            if (CurrentLocation != null)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
            }
        }
        public void MoveEast()
        {
            if (CurrentLocation != null)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
            }
        }


       

    }

}
