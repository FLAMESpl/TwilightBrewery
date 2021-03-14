namespace TwilightBrewery.Models.Factions
{
    public record Leader(
        string Name, 
        string Title, 
        string Flavour, 
        string UnlockCondition,
        Ability Ability);
}
