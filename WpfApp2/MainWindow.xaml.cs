using MahApps.Metro.Controls;
using System.Windows;

namespace WpfApp2;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : MetroWindow
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private SubWindow _subWindow;
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        if (_subWindow is null)
        {
            _subWindow = new();
            _subWindow.Owner = this;
        }
        _subWindow.Show();
    }
}
