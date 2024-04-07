﻿using System.Windows;
using Microsoft.Win32;
using System;

using System.Windows.Media.Imaging;
using System.Windows.Documents;
using Engine.EventArgs;
using Engine.Models;
using Engine.ViewModels;
using System.Windows.Controls;

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
            UpdateSelectedItemImage();
            //END
            _gameSession.OnMessageRaised += OnGameMessageRaised;
            DataContext = _gameSession;
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

        //SOMETHING HERE
        private void ItemComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Update the image when the selection changes
            UpdateSelectedItemImage();
        }

        private void UpdateSelectedItemImage()
        {
            // Get the selected item from the ComboBox
            ComboBoxItem selectedItem = (ComboBoxItem)itemComboBox.SelectedItem;

            if (selectedItem != null)
            {
                // Get the content (text) of the selected item
                string selectedContent = selectedItem.Content.ToString();

                // Display the corresponding image based on the selected item
                ShowSelectedItemImage(selectedContent);
            }
        }

        private void ShowSelectedItemImage(string selectedItem)
        {
            // Set the image source based on the selected item
            switch (selectedItem)
            {
                case "Iron Sword":
                    itemImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/Potion.jpg"));
                    break;

                case "Potion":
                    itemImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/Potion.jpg"));
                    break;
                case "car":
                    itemImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/GoldenSword.png"));
                    break;

                // Add more cases for additional items

                default:
                    // Default case if the selected item is not recognized
                    itemImage.Source = null;
                    break;
            }
        }



    }
}