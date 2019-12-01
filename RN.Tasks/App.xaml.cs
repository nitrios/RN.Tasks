using Avalonia;
using Avalonia.Markup.Xaml;

namespace RN.Tasks
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}