
using System.Windows;

namespace G24W1402WPFDialog;

public partial class GundamDlg : Window
{
    public GundamDlg()
    {
        InitializeComponent();
        Name2.Focus();
    }
    public string MSName
    {
        get { return Name2.Text; }
    }
    public string MSModel => Model.Text;
    public string MSParty => Party.Text;
    private void OnOk(object sender, EventArgs e) 
    {
        if (string.IsNullOrEmpty(MSName))
        {
            MessageBox.Show("이름을 입력하십쇼.","입력 부족",MessageBoxButton.OK,MessageBoxImage.Warning);

            Name2.Focus();
            return;
        }
        if (string.IsNullOrEmpty(MSModel))
        {
            MessageBox.Show(
                "모델을 입력하십시오.",
                "입력 부족",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);

            Model.Focus();
            return;
        }
        if (string.IsNullOrEmpty(MSParty))
        {
            MessageBox.Show(
                "소속을 입력하십시오.",
                "입력 부족",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);

            Party.Focus();
            return;
        }

        DialogResult = true;
    }
    private void OnCancel(object sender, EventArgs e)
    {
        DialogResult = false;
    }
}
