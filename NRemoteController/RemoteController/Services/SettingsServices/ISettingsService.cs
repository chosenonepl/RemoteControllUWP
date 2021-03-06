using System;
using Windows.UI.Xaml;

namespace RemoteController.Services.SettingsServices
{
    public interface ISettingsService
    {
        bool UseShellBackButton { get; set; }
        ApplicationTheme AppTheme { get; set; }
        TimeSpan CacheMaxDuration { get; set; }
        string IpAddress { get; set; }
    }
}
