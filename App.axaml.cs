using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace AppDiscordRPC
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                /// Запуск программы
                desktop.MainWindow = new MainWindow();

                /// Параметр изменения размера экрана
                desktop.MainWindow.CanResize = false;
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}