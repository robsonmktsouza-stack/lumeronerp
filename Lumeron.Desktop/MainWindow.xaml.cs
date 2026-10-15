using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Lumeron.Desktop;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        if (!DesignerProperties.GetIsInDesignMode(this))
        {
            ApplyWindowIcon();
        }
    }

    private void ApplyWindowIcon()
    {
        // Usa o simbolo do proprio logotipo, sem depender de um segundo arquivo.
        var logo = new BitmapImage(
            new Uri("pack://application:,,,/Lumeron.Desktop;component/Assets/LumeronLogo.png"));

        Icon = new CroppedBitmap(logo, new Int32Rect(0, 0, 285, 233));
    }
}
