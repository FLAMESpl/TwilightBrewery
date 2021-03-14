using System.Collections.Generic;

namespace TwilightBrewery.Models.Factions
{
    public record Unit(
        string Name,
        UnitTemplate Template,
        int Mark,
        int Capacity,
        int Combat, 
        int Cost,
        int Movement,
        int ProductionValue,
        string Text,
        IReadOnlyCollection<CommonAbility> Abilities,
        TechnologicalRequirement UpgradeRequirement);
}
