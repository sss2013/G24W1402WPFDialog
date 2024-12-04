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
        if (dialog.ShowDialog() != true)
            return;

        Result.Text += $"{dialog.MSParty}의 " + $"{dialog.MSModel}" +
            $"{dialog.Name}{(HasJongsung(dialog.MSName) ? "이" : "가")}" + "추가되었습니다.\n";
    }
    public bool HasJongsung(string str)
    {
        if (str.Length < 1)
            return true;
        char last = str[str.Length - 1];
        return (last - 44032) % 28 != 0;
    }
}
