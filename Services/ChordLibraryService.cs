namespace GuitarChordExplorer.Services;

using GuitarChordExplorer.Models;

public class ChordLibraryService
{
    private static readonly Dictionary<string, ChordVoicing> Library = BuildLibrary();

    public ChordVoicing? GetVoicing(string root, ChordQuality quality)
    {
        var key = $"{root}_{quality}";
        return Library.TryGetValue(key, out var voicing) ? voicing : null;
    }

    private static Dictionary<string, ChordVoicing> BuildLibrary()
    {
        var lib = new Dictionary<string, ChordVoicing>();

        void Add(ChordVoicing v) =>
            lib[$"{v.Root}_{v.Quality}"] = v;

        Add(new("C",  ChordQuality.Major, [-1, 3, 2, 0, 1, 0], 1));
        Add(new("D",  ChordQuality.Major, [-1,-1, 0, 2, 3, 2], 1));
        Add(new("E",  ChordQuality.Major, [ 0, 2, 2, 1, 0, 0], 1));
        Add(new("G",  ChordQuality.Major, [ 3, 2, 0, 0, 0, 3], 1));
        Add(new("A",  ChordQuality.Major, [-1, 0, 2, 2, 2, 0], 1));

        Add(new("F",  ChordQuality.Major, [ 1, 3, 3, 2, 1, 1], 1, 1, 0, 5));
        Add(new("Gb", ChordQuality.Major, [ 2, 4, 4, 3, 2, 2], 2, 2, 0, 5));
        Add(new("Ab", ChordQuality.Major, [ 4, 6, 6, 5, 4, 4], 4, 4, 0, 5));

        Add(new("Bb", ChordQuality.Major, [-1, 1, 3, 3, 3, 1], 1, 1, 1, 5));
        Add(new("B",  ChordQuality.Major, [-1, 2, 4, 4, 4, 2], 2, 2, 1, 5));
        Add(new("Db", ChordQuality.Major, [-1, 4, 6, 6, 6, 4], 4, 4, 1, 5));
        Add(new("Eb", ChordQuality.Major, [-1, 6, 8, 8, 8, 6], 6, 6, 1, 5));

        Add(new("E",  ChordQuality.Minor, [ 0, 2, 2, 0, 0, 0], 1));
        Add(new("A",  ChordQuality.Minor, [-1, 0, 2, 2, 1, 0], 1));
        Add(new("D",  ChordQuality.Minor, [-1,-1, 0, 2, 3, 1], 1));

        Add(new("F",  ChordQuality.Minor, [ 1, 3, 3, 1, 1, 1], 1, 1, 0, 5));
        Add(new("Gb", ChordQuality.Minor, [ 2, 4, 4, 2, 2, 2], 2, 2, 0, 5));
        Add(new("G",  ChordQuality.Minor, [ 3, 5, 5, 3, 3, 3], 3, 3, 0, 5));
        Add(new("Ab", ChordQuality.Minor, [ 4, 6, 6, 4, 4, 4], 4, 4, 0, 5));

        Add(new("Bb", ChordQuality.Minor, [-1, 1, 3, 3, 2, 1], 1, 1, 1, 5));
        Add(new("B",  ChordQuality.Minor, [-1, 2, 4, 4, 3, 2], 2, 2, 1, 5));
        Add(new("C",  ChordQuality.Minor, [-1, 3, 5, 5, 4, 3], 3, 3, 1, 5));
        Add(new("Db", ChordQuality.Minor, [-1, 4, 6, 6, 5, 4], 4, 4, 1, 5));
        Add(new("Eb", ChordQuality.Minor, [-1, 6, 8, 8, 7, 6], 6, 6, 1, 5));

        Add(new("B",  ChordQuality.Diminished, [-1,-1, 0, 1, 0, 1], 1));
        Add(new("Ab", ChordQuality.Diminished, [-1,-1, 0, 1, 0, 1], 1));
        Add(new("D",  ChordQuality.Diminished, [-1,-1, 0, 1, 0, 1], 1));

        Add(new("C",  ChordQuality.Diminished, [-1,-1, 1, 2, 1, 2], 1));
        Add(new("A",  ChordQuality.Diminished, [-1,-1, 1, 2, 1, 2], 1));
        Add(new("Eb", ChordQuality.Diminished, [-1,-1, 1, 2, 1, 2], 1));

        Add(new("Db", ChordQuality.Diminished, [-1,-1, 2, 3, 2, 3], 2));
        Add(new("Bb", ChordQuality.Diminished, [-1,-1, 2, 3, 2, 3], 2));
        Add(new("E",  ChordQuality.Diminished, [-1,-1, 2, 3, 2, 3], 2));
        Add(new("G",  ChordQuality.Diminished, [-1,-1, 2, 3, 2, 3], 2));

        Add(new("F",  ChordQuality.Diminished, [-1,-1, 3, 4, 3, 4], 3));
        Add(new("Gb", ChordQuality.Diminished, [-1,-1, 4, 5, 4, 5], 4));

        return lib;
    }
}
