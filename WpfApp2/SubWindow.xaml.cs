using MahApps.Metro.Controls;
using System.Windows;

namespace WpfApp2;
/// <summary>
/// SubWindow.xaml の相互作用ロジック
/// </summary>
public partial class SubWindow : MetroWindow
{
    public SubWindow()
    {
        InitializeComponent();
    }

    private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
        e.Cancel = true;
        this.Visibility = Visibility.Hidden;
    }
}
