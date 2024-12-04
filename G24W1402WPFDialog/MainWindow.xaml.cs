using System.Windows;

namespace G24W1402WPFDialog;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void OnAdd(object sender, RoutedEventArgs e)
    {
        GundamDlg dialog = new GundamDlg();
        dialog.ShowDialog();
    }
}
