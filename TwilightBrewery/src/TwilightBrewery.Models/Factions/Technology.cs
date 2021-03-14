using System.Collections.Generic;

namespace TwilightBrewery.Models.Factions
{
    public record Technology(
        string? Action, 
        IReadOnlyCollection<string> Effects,
        TechnologyKind Kind,
        TechnologicalRequirement Requirement);
}
