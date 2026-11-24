using System.Globalization;
using System.Text.Json;
namespace Weekly_Planner.Models
{
    public static class ActivityStorage
    {

        private static JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        public static PlannerDay[]? Import(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path)) return null;

            var json = File.ReadAllText(path);

            var days = JsonSerializer.Deserialize<PlannerDay[]>(json,options);
            return days;
        }

        public static bool Export(string path , PlannerDay[] days)
        {
            if (string.IsNullOrWhiteSpace(path) || days is null)
                return false;

            Directory.CreateDirectory(Path.GetDirectoryName(path)!);

            var json = JsonSerializer.Serialize(days,options);

            File.WriteAllText(path,json);
            
            return true;
        }
    }
}
