using System.Collections.Generic;

namespace TwilightBrewery.Models.Factions
{
    public record Faction(
        string Name,
        int Commodities,
        IReadOnlyCollection<Ability> Abilities,
        IReadOnlyCollection<Ability> PromissoryNotes,
        IReadOnlyCollection<string> StartingTechnologies,
        IReadOnlyDictionary<UnitTemplate, int> StartingUnits,
        IReadOnlyCollection<Technology> Technologies,
        IReadOnlyCollection<Unit> Units,
        IReadOnlyCollection<Leader> Agents,
        IReadOnlyCollection<Leader> Commanders,
        IReadOnlyCollection<Leader> Heroes,
        Quote FlavourQuote,
        Lore Lore);
}
