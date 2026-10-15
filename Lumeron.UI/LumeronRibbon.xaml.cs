
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Media;

namespace Lumeron.UI
{
    public partial class LumeronRibbon : UserControl
    {
        public LumeronRibbon()
        {
            InitializeComponent();
        }

        private void MainRibbon_Loaded(object sender, RoutedEventArgs e)
        {
            if (sender is not Ribbon ribbon)
                return;

            ribbon.ApplyTemplate();

            if (VisualTreeHelper.GetChildrenCount(ribbon) == 0)
                return;

            if (VisualTreeHelper.GetChild(ribbon, 0) is Grid grid &&
                grid.RowDefinitions.Count > 0)
            {
                // Remove o espaço superior reservado pelo Ribbon.
                grid.RowDefinitions[0].Height = new GridLength(0);
            }
        }
    }
}
