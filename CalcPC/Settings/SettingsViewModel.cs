using System.Globalization;

using CommunityToolkit.Mvvm.ComponentModel;

using MaterialDesignThemes.Wpf;

namespace CalcPC.Settings;

public partial class SettingsViewModel : ObservableObject
{
    [ObservableProperty]
    private BaseTheme _theme;

    [ObservableProperty]
    private List<CultureInfo> _availableCultures = new();

    [ObservableProperty]
    private CultureInfo _selectedLang = CultureInfo.CurrentCulture;


    partial void OnThemeChanged(BaseTheme value)
    {
        PaletteHelper paletteHelper = new();
        Theme theme = paletteHelper.GetTheme();
        theme.SetBaseTheme(value);
        paletteHelper.SetTheme(theme);
    }

    static BaseTheme SetThemeProperty() => new PaletteHelper().GetTheme().GetBaseTheme();

    public SettingsViewModel()
    {
        _theme = SetThemeProperty();
    }
}
