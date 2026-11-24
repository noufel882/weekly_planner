using System.Globalization;
using System.Text.Json;
namespace Weekly_Planner.Models
{
    /// <summary>
    /// Provides JSON-based persistence for weekly planner data.
    /// </summary>
    public static class ActivityStorage
    {

        private static readonly JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        /// <summary>
        /// Imports weekly planner data from a JSON file.
        /// </summary>
        /// <param name="path">The full path of the JSON file.</param>
        /// <returns>An array of planner days, or <see langword="null"/> when the path is invalid or the file does not exist.</returns>
        /// <exception cref="JsonException">Thrown when the file does not contain valid JSON for the planner model.</exception>
        /// <remarks>This operation only checks that the path and file are valid; deserialization may raise JSON-related exceptions.</remarks>
        public static PlannerDay[]? Import(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path)) return null;

            var json = File.ReadAllText(path);

            var days = JsonSerializer.Deserialize<PlannerDay[]>(json,options);
            return days;
        }

        /// <summary>
        /// Exports weekly planner data to a JSON file.
        /// </summary>
        /// <param name="path">The full destination file path.</param>
        /// <param name="days">The planner days to serialize.</param>
        /// <returns><see langword="true"/> when the file is written successfully; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="IOException">Thrown when the destination cannot be written.</exception>
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
