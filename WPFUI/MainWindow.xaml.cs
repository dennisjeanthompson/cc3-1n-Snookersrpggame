using System.Windows;
using Microsoft.Win32;
using System;

using System.Windows.Media.Imaging;
using System.Windows.Documents;
using Engine.EventArgs;
using Engine.Models;
using Engine.ViewModels;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly GameSession _gameSession = new GameSession();
        public MainWindow()
        {
            InitializeComponent();
            //ADDED THIS 
          //  UpdateSelectedItemImage();
            //END
            _gameSession.OnMessageRaised += OnGameMessageRaised;
            DataContext = _gameSession;
        }

        private void WeaponComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the selected item from the ComboBox
            GameItem selectedItem = (GameItem)ItemComboBox.SelectedItem;

            // Check if an item is selected
            if (selectedItem != null)
            {
                // Update the image source in the other grid with the selected item's image source
                SelectedItemImage.Source = new BitmapImage(new Uri(selectedItem.ImagePath, UriKind.RelativeOrAbsolute));

                // Make the image visible
                SelectedItemImage.Visibility = Visibility.Visible;
            }
            else
            {
                // Hide the image if no item is selected
                SelectedItemImage.Visibility = Visibility.Collapsed;
            }
        }

        private void ConsumableComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the selected consumable from the ComboBox
            GameItem selectedConsumable = (GameItem)ConsumableComboBox.SelectedItem;

            // Check if a consumable is selected
            if (selectedConsumable != null)
            {
                // Update the image source in the other grid with the selected item's image source
                SelectedItemImage.Source = new BitmapImage(new Uri(selectedConsumable.ImagePath, UriKind.RelativeOrAbsolute));

                // Make the image visible
                SelectedItemImage.Visibility = Visibility.Visible;
            }
            else
            {
                // Hide the image if no item is selected
                SelectedItemImage.Visibility = Visibility.Collapsed;
            }
        }



        private void OnClick_MoveNorth(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveNorth();
        }
        private void OnClick_MoveWest(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveWest();
        }
        private void OnClick_MoveEast(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveEast();
        }
        private void OnClick_MoveSouth(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveSouth();
        }
        private void OnClick_AttackMonster(object sender, RoutedEventArgs e)
        {
            _gameSession.AttackCurrentMonster();
        }
        private void OnClick_UseCurrentConsumable(object sender, RoutedEventArgs e)
        {
            _gameSession.UseCurrentConsumable();
        }
        private void OnGameMessageRaised(object sender, GameMessageEventArgs e)
        {
            GameMessages.Document.Blocks.Add(new Paragraph(new Run(e.Message)));
            GameMessages.ScrollToEnd();
        }
        private void OnClick_DisplayTradeScreen(object sender, RoutedEventArgs e)
        {
            TradeScreen tradeScreen = new TradeScreen();
            tradeScreen.Owner = this;
            tradeScreen.DataContext = _gameSession;
            tradeScreen.ShowDialog();
        }
        private void OnClick_Craft(object sender, RoutedEventArgs e)
        {
            Recipe recipe = ((FrameworkElement)sender).DataContext as Recipe;
            _gameSession.CraftItemUsing(recipe);
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void ItemName_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Handle the mouse click event here
            var cell = sender as DataGridCell;
            if (cell != null && cell.Content is TextBlock textBlock && textBlock.DataContext is GameItem
                selectedItem)
            {
                // Assuming YourItemType has a property named ImagePath
                if (!string.IsNullOrEmpty(selectedItem.ImagePath))
                {
                    SelectedItemImage.Source = new BitmapImage(new Uri(selectedItem.ImagePath));
                }
                else
                {
                    // If no image path is available, you can set a default image or do nothing
                    SelectedItemImage.Source = null;
                }
            }
        }
    }
}