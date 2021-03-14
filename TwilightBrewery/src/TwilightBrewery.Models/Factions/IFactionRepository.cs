using System.Threading.Tasks;

namespace TwilightBrewery.Models.Factions
{
    public interface IFactionRepository
    {
        Task Delete(string code);
        Task<Faction?> Find(string code);
        Task Save(string code, Faction faction);
    }
}
