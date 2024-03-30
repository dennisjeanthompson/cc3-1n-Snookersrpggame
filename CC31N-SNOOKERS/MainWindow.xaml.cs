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

using Engine.ViewModels;
namespace CC31N_SNOOKERS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameSession _gameSession;
        public MainWindow()
        {
            InitializeComponent();
            _gameSession = new GameSession();
          DataContext = _gameSession;
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
     /*   private void InventoryGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Clear the existing items in the DataGrid
            InventoryGrid.Items.Clear();

            // Get the selected item from the Inventory DataGrid
            var selectedInventoryItem = InventoryGrid.SelectedItem as GameItem;

            // If a valid item is selected, update the image
            if (selectedInventoryItem != null)
            {
                // Assuming you have a property named ImagePath in your GameItem class
                // Update the image source with the selected item's image path
                if (!string.IsNullOrEmpty(selectedInventoryItem.ImageName))
                {
                    // Construct the URI for the image path
                    var imagePathUri = new Uri(selectedInventoryItem.ImageName, UriKind.RelativeOrAbsolute);

                    // Create a BitmapImage and set its source to the constructed URI
                    ItemImage.Source = new BitmapImage(imagePathUri);
                }
                else
                {
                    // Clear the image if the image path is empty
                    ItemImage.Source = null;
                }
            }
            else
            {
                // Clear the image if no item is selected
                ItemImage.Source = null;
            }
        }
     */


    }
}