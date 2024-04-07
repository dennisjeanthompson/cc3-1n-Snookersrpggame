using Engine.Factories;
using Engine.Models;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Engine.ViewModels
{
    public class GameSession : BaseNotifcationClass
    {
        private Location? _currentLocation;
        private Monster _currentMonster;
        public Player? CurrentPlayer { get; set; }
        public DataGrid InventoryGrid { get; set; }
        public Image ItemImage { get; set; }
        public Location? CurrentLocation {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;

                OnPropertyChanged(nameof(CurrentLocation));
                OnPropertyChanged(nameof(HasLocationToNorth));
                OnPropertyChanged(nameof(HasLocationToSouth));
                OnPropertyChanged(nameof(HasLocationToWest));
                OnPropertyChanged(nameof(HasLocationToEast));
                GivePlayerQuestsAtLocation();
                GetMonsterAtLocation();
            }
        }
        public Monster CurrentMonster
        {
            get { return _currentMonster; }
            set
            {
                _currentMonster = value;
                OnPropertyChanged(nameof(CurrentMonster));
                OnPropertyChanged(nameof(HasMonster));
            }
        }
        public World CurrentWorld { get; set; }
        public bool HasLocationToNorth => CurrentLocation != null && CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null;
        public bool HasLocationToSouth => CurrentLocation != null && CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null;

        public bool HasLocationToEast => CurrentLocation != null && CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null;

        public bool HasLocationToWest => CurrentLocation != null && CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null;
        public bool HasMonster => CurrentMonster != null;
        public GameSession()
        {
            CurrentPlayer = new Player
            {
                Name = "Scott",
                CharacterClass = "Fighter",
                HitPoints = 10,
                Gold = 1000000,
                ExperiencePoints = 0,
                Level = 1
            };
            CurrentWorld = WorldFactory.CreateWorld();
            CurrentLocation = CurrentWorld.LocationAt(0, -1);
            CurrentPlayer.Inventory.Add(ItemFactory.CreateGameItem(100));
            CurrentPlayer.Inventory.Add(ItemFactory.CreateGameItem(100));
            CurrentPlayer.Inventory.Add(ItemFactory.CreateGameItem(101));
            CurrentPlayer.Inventory.Add(ItemFactory.CreateGameItem(102));
            CurrentPlayer.Inventory.Add(ItemFactory.CreateGameItem(103));
            CurrentPlayer.Inventory.Add(ItemFactory.CreateGameItem(104));
            CurrentPlayer.Inventory.Add(ItemFactory.CreateGameItem(201));
            CurrentPlayer.Inventory.Add(ItemFactory.CreateGameItem(202));
            CurrentPlayer.Inventory.Add(ItemFactory.CreateGameItem(203));
            CurrentPlayer.Inventory.Add(ItemFactory.CreateGameItem(204));
            CurrentPlayer.Inventory.Add(ItemFactory.CreateGameItem(205));
            CurrentPlayer.Inventory.Add(ItemFactory.CreateGameItem(206));
            CurrentPlayer.Inventory.Add(ItemFactory.CreateGameItem(207));
            CurrentPlayer.Inventory.Add(ItemFactory.CreateGameItem(208));
            CurrentPlayer.Inventory.Add(ItemFactory.CreateGameItem(209));
            
            InventoryGrid = new DataGrid();
            ItemImage = new Image();
            InventoryGrid.SelectionChanged += InventoryGrid_SelectionChanged;
            /*


            _standardGameItems.Add(new Weapon(100, "Iron Sword", 9000, "/ Engine; component / Images / ItemImage /RedSwordzx.png", 1, 3));
            _standardGameItems.Add(new Weapon(101, "Fire Sword", 20000, "/ Engine; component / Images / ItemImage /fireezzz.png", 1, 3));
            _standardGameItems.Add(new Weapon(102, "Golden Sword", 99000, "/ Engine; component / Images / ItemImage / sowrdssz.jpg", 1,5));
            _standardGameItems.Add(new Weapon(103, "Pink Sword", 50000, "/ Engine; component / Images / ItemImage / SwordReed.png", 1, 3));
            _standardGameItems.Add(new Weapon(104, "Blue Sword", 60000, "/ Engine; component / Images / ItemImage /glowing_sword_only__3045701784.png", 1, 6));
            _standardGameItems.Add(new GameItem(201, "Potion", 12000, "/ Engine; component / Images / ItemImage / Potionz.png"));//healing??
            _standardGameItems.Add(new GameItem(202, "skulle", 1000, "/ Engine; component / Images / ItemImage / wierd_small_evil_item__3517160176.png"));
            _standardGameItems.Add(new GameItem(203, "Skullz", 2000, "/ Engine; component / Images / ItemImage / wierd_small_evil_item_dead__1343190293.png"));
            _standardGameItems.Add(new GameItem(204, "Bear Claw", 9500, "/ Engine; component / Images / ItemImage / BeareClawz.png"));
            _standardGameItems.Add(new GameItem(205, "Bear Gallbladder",1200 , "/ Engine; component / Images / ItemImage /BearGallblader.png"));
            _standardGameItems.Add(new GameItem(206, "Centepede Essence", 1000, "/ Engine; component / Images / ItemImage / CentepedeEssence.jpg"));
            _standardGameItems.Add(new GameItem(207, "Centepede Eye", 1000, "/ Engine; component / Images / ItemImage / EYEcentepede.jpg"));
            _standardGameItems.Add(new GameItem(208, "Serpent Scale", 2000, "/ Engine; component / Images / ItemImage / SerpentScale.png"));
            _standardGameItems.Add(new GameItem(209, "Toxic Gland", 3000, "/ Engine; component / Images / ItemImage / ToxicGland.png"));











            */

        }

        private void InventoryGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Your logic for handling selection change in the InventoryGrid goes here
            // This method will be triggered when an item is selected in the InventoryGrid
            var selectedInventoryItem = InventoryGrid.SelectedItem as GameItem;

            // Update the ItemImage control with the selected item's image
            if (selectedInventoryItem != null && ItemImage != null)
            {
                ItemImage.Source = new BitmapImage(new Uri(selectedInventoryItem.ImageName, UriKind.RelativeOrAbsolute));
            }
        }
        public void MoveNorth()
        {
            if (HasLocationToNorth && CurrentLocation != null)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
            }
        }
        public void MoveSouth()
        {
            if (HasLocationToSouth && CurrentLocation != null)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
            }
        }
        public void MoveWest()
        {
            if (HasLocationToWest && CurrentLocation != null)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
            }
        }
        public void MoveEast()
        {
            if (HasLocationToEast && CurrentLocation != null)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
            }
        }

        private void GivePlayerQuestsAtLocation()
        {
            foreach (Quest quest in CurrentLocation.QuestsAvailableHere)
            {
                if (!CurrentPlayer.Quests.Any(q => q.PlayerQuest.Id == quest.Id))
                {
                    CurrentPlayer.Quests.Add(new QuestStatus(quest));
                }
            }
        }

        private void GetMonsterAtLocation()
        {
            CurrentMonster = CurrentLocation.GetMonster();
        }
    }

}
