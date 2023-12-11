using System.Windows.Controls;

namespace CalcPC.Settings;

/// <summary>
/// Logika interakcji dla klasy SettingsView.xaml
/// </summary>
public partial class SettingsView : UserControl
{
    public SettingsView()
    {
        InitializeComponent();
    }
    public SettingsView(SettingsViewModel viewModel)
    {
        DataContext = viewModel;
        InitializeComponent();
    }
}
