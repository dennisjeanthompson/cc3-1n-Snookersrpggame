using System.Reflection.PortableExecutable;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using Engine.EventArgs;
using Engine.Models;
using Engine.ViewModels;
using WPFUI;
namespace CC31N_SNOOKERS
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
            _gameSession = new GameSession();
            _gameSession.OnMessageRaised += OnGameMessageRaised;
            DataContext = _gameSession;
            _gameSession.ItemImage = ItemImage;
        }
        private void OnClick_MoveNorth(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveNorth();
        }
        private void OnClick_MoveSouth(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveSouth();
        }
        private void OnClick_MoveWest(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveWest();
        }
        private void OnClick_MoveEast(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveEast();
        }
        private void InventoryGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the selected item from the Inventory DataGrid
            var selectedInventoryItem = InventoryGrid.SelectedItem as GameItem;

            // Display the image corresponding to the selected item
            if (selectedInventoryItem != null)
            {
                // Set the Image source based on the selected item
                ItemImage.Source = new BitmapImage(new Uri(selectedInventoryItem.ImageName, UriKind.RelativeOrAbsolute));
            }
        }
        /*
         <Grid x:Name="ImageDisplayGrid" Grid.Row="0" Grid.Column="0">
               <Label Grid.Row="0"  Grid.Column= "0" Content= "Item Information"   BorderBrush= "DarkRed" BorderThickness= "4" FontWeight= "ExtraBold" Foreground= "Red" FontSize= "19"
                      />
               < Image x:Name= "ItemImage" Stretch= "UniformToFill" />
        </ Grid >
       <    < TabControl Background= "Blue"  Foreground= "Red" >
             < TabItem Header= "Inventory" Background= "DarkBlue"   FontSize= "11" Foreground= "Red" >
                   < DataGrid ItemsSource= "{Binding CurrentPlayer.Inventory}"
                         AutoGenerateColumns= "False"
                             HeadersVisibility= "Column" Background= "Blue"  Foreground= "Red"  SelectionChanged= "InventoryGrid_SelectionChanged" x:Name= "InventoryGrid" >
                        < DataGrid.Columns >
                            < DataGridTextColumn Header= "Description"
                                               Binding= "{Binding Name}"
                                              Width= "*" />
                           < DataGridTextColumn Header= "Price"
                                               Binding= "{Binding Price}"
                                               Width= "Auto" />
                       </ DataGrid.Columns >
                   </ DataGrid >
              </ TabItem >
        */
        private void OnClick_AttackMonster(object sender, RoutedEventArgs e)
        {
            _gameSession.AttackCurrentMonster();
        }
        private void OnGameMessageRaised(object? sender, GameMessageEventArgs e)
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


    }
}