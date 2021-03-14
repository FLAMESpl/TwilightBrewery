using ReactiveUI;

namespace TwilightBrewery.ViewModels
{
    public class ViewModelBase : ReactiveObject
    {
        public string Greeting { get; } = "Hello darkness my old friend";
    }
}
