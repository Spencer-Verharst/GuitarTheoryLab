namespace GuitarChordExplorer.Services;

using GuitarChordExplorer.Models;

public class MusicTheoryService
{
    private static readonly Dictionary<string, string[]> MajorKeyNotes = new()
    {
        ["C"]  = ["C",  "D",  "E",  "F",  "G",  "A",  "B"],
        ["Db"] = ["Db", "Eb", "F",  "Gb", "Ab", "Bb", "C"],
        ["D"]  = ["D",  "E",  "Gb", "G",  "A",  "B",  "Db"],
        ["Eb"] = ["Eb", "F",  "G",  "Ab", "Bb", "C",  "D"],
        ["E"]  = ["E",  "Gb", "Ab", "A",  "B",  "Db", "Eb"],
        ["F"]  = ["F",  "G",  "A",  "Bb", "C",  "D",  "E"],
        ["Gb"] = ["Gb", "Ab", "Bb", "B",  "Db", "Eb", "F"],
        ["G"]  = ["G",  "A",  "B",  "C",  "D",  "E",  "Gb"],
        ["Ab"] = ["Ab", "Bb", "C",  "Db", "Eb", "F",  "G"],
        ["A"]  = ["A",  "B",  "Db", "D",  "E",  "Gb", "Ab"],
        ["Bb"] = ["Bb", "C",  "D",  "Eb", "F",  "G",  "A"],
        ["B"]  = ["B",  "Db", "Eb", "E",  "Gb", "Ab", "Bb"],
    };

    private static readonly Dictionary<string, string[]> MinorKeyNotes = new()
    {
        ["Am"]  = ["A",  "B",  "C",  "D",  "E",  "F",  "G"],
        ["Bbm"] = ["Bb", "C",  "Db", "Eb", "F",  "Gb", "Ab"],
        ["Bm"]  = ["B",  "Db", "D",  "E",  "Gb", "G",  "A"],
        ["Cm"]  = ["C",  "D",  "Eb", "F",  "G",  "Ab", "Bb"],
        ["Dbm"] = ["Db", "Eb", "E",  "Gb", "Ab", "A",  "B"],
        ["Dm"]  = ["D",  "E",  "F",  "G",  "A",  "Bb", "C"],
        ["Ebm"] = ["Eb", "F",  "Gb", "Ab", "Bb", "B",  "Db"],
        ["Em"]  = ["E",  "Gb", "G",  "A",  "B",  "C",  "D"],
        ["Fm"]  = ["F",  "G",  "Ab", "Bb", "C",  "Db", "Eb"],
        ["Gbm"] = ["Gb", "Ab", "A",  "B",  "Db", "D",  "E"],
        ["Gm"]  = ["G",  "A",  "Bb", "C",  "D",  "Eb", "F"],
        ["Abm"] = ["Ab", "Bb", "B",  "Db", "Eb", "E",  "Gb"],
    };

    private static readonly ChordQuality[] MajorQualities =
        [ChordQuality.Major, ChordQuality.Minor, ChordQuality.Minor,
         ChordQuality.Major, ChordQuality.Major, ChordQuality.Minor,
         ChordQuality.Diminished];

    private static readonly ChordQuality[] MinorQualities =
        [ChordQuality.Minor, ChordQuality.Diminished, ChordQuality.Major,
         ChordQuality.Minor, ChordQuality.Minor, ChordQuality.Major,
         ChordQuality.Major];

    private static readonly string[] MajorRomanNumerals =
        ["I", "ii", "iii", "IV", "V", "vi", "vii°"];

    private static readonly string[] MinorRomanNumerals =
        ["i", "ii°", "III", "iv", "v", "VI", "VII"];

    public static IReadOnlyList<string> AvailableKeys      => [.. MajorKeyNotes.Keys];
    public static IReadOnlyList<string> AvailableMinorKeys => [.. MinorKeyNotes.Keys];

    public List<ChordInfo> GetDiatonicChords(string key)
    {
        string[]? notes;
        ChordQuality[] qualities;
        string[] romans;

        if (MinorKeyNotes.TryGetValue(key, out notes))
        {
            qualities = MinorQualities;
            romans    = MinorRomanNumerals;
        }
        else if (MajorKeyNotes.TryGetValue(key, out notes))
        {
            qualities = MajorQualities;
            romans    = MajorRomanNumerals;
        }
        else
        {
            throw new ArgumentException($"Unknown key: {key}");
        }

        var chords = new List<ChordInfo>();
        for (int i = 0; i < 7; i++)
        {
            chords.Add(new ChordInfo
            {
                Root         = notes[i],
                Quality      = qualities[i],
                RomanNumeral = romans[i],
                ScaleDegree  = i + 1
            });
        }
        return chords;
    }
}
