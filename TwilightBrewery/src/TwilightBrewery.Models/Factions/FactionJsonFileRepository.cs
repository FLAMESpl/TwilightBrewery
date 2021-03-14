using Microsoft.Extensions.Options;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TwilightBrewery.Models.Factions
{
    internal class FactionJsonFileRepository : IFactionRepository
    {
        private readonly IOptionsSnapshot<FactionSettings> settings;
        private readonly JsonSerializerOptions serializerOptions = new()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
            WriteIndented = true
        };

        public FactionJsonFileRepository(IOptionsSnapshot<FactionSettings> settings)
        {
            this.settings = settings;
        }

        public Task Delete(string code)
        {
            Directory.Delete(GetDirectoryPath(code), recursive: true);
            return Task.CompletedTask;
        }

        public async Task<Faction?> Find(string code)
        {
            var path = GetJsonFilePath(code);

            if (File.Exists(path))
            {
                using var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                return await JsonSerializer.DeserializeAsync<Faction>(fileStream, serializerOptions);
            }
            else
            {
                return null;
            }
        }

        public async Task Save(string code, Faction faction)
        {
            Directory.CreateDirectory(GetDirectoryPath(code));
            using var fileStream = new FileStream(GetJsonFilePath(code), FileMode.Create, FileAccess.Write);
            await JsonSerializer.SerializeAsync(fileStream, serializerOptions);
        }

        private string GetDirectoryPath(string code) => Path.Combine(settings.Value.FileDirectory, code);

        private string GetJsonFilePath(string code) => Path.Combine(GetDirectoryPath(code), $"{code}.json");
    }
}
