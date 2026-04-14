namespace GuitarChordExplorer.Services;

using GuitarChordExplorer.Models;

public class ScaleService
{
    private static readonly string[] Chromatic =
        ["C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "Bb", "B"];

    public static IReadOnlyList<string> AvailableRoots => Chromatic;

    private static readonly (string Name, int[] Steps, string Pattern, string Description)[] Definitions =
    [
        ("Major",            [2,2,1,2,2,2,1], "W–W–H–W–W–W–H",  "Bright and happy. The foundation of Western music."),
        ("Natural Minor",    [2,1,2,2,1,2,2], "W–H–W–W–H–W–W",  "Dark and emotional. Shares notes with its relative major."),
        ("Major Pentatonic", [2,2,3,2,3],     "W–W–WH–W–WH",    "5-note major scale. Great for country and rock leads."),
        ("Minor Pentatonic", [3,2,2,3,2],     "WH–W–W–WH–W",    "5-note minor scale. The go-to for blues and rock solos."),
        ("Blues",            [3,2,1,1,3,2],   "WH–W–H–H–WH–W",  "Minor pentatonic + a ♭5 'blue note'. Essential for blues."),
        ("Dorian",           [2,1,2,2,2,1,2], "W–H–W–W–W–H–W",  "Minor with a raised 6th. Common in jazz, funk, and rock."),
        ("Mixolydian",       [2,2,1,2,2,1,2], "W–W–H–W–W–H–W",  "Major with a ♭7. Heard everywhere in blues and classic rock."),
    ];

    public List<ScaleInfo> GetScales(string root)
    {
        int rootIndex = Array.IndexOf(Chromatic, root);
        if (rootIndex < 0) throw new ArgumentException($"Unknown root: {root}");

        var result = new List<ScaleInfo>();
        foreach (var (name, steps, pattern, desc) in Definitions)
        {
            var notes = new string[steps.Length + 1];
            notes[0] = root;
            int idx = rootIndex;
            for (int i = 0; i < steps.Length - 1; i++)
            {
                idx = (idx + steps[i]) % 12;
                notes[i + 1] = Chromatic[idx];
            }
            result.Add(new ScaleInfo
            {
                Name        = name,
                Notes       = notes[..^1],
                Pattern     = pattern,
                Description = desc
            });
        }
        return result;
    }
}
