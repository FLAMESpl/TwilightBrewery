using System.Diagnostics.CodeAnalysis;

namespace TwilightBrewery.Models.Factions
{
    public class FactionSettings
    {
        [AllowNull]
        public string FileDirectory { get; set; }
    }
}
