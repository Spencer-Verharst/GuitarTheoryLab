namespace GuitarChordExplorer.Models;

public enum ChordQuality
{
    Major,
    Minor,
    Diminished
}

public record ChordVoicing(
    string Root,
    ChordQuality Quality,
    int[] Frets,
    int BaseFret,
    int? BarreFret = null,
    int BarreFromString = 0,
    int BarreToString = 5
)
{
    public string ChordName => Quality switch
    {
        ChordQuality.Minor => $"{Root}m",
        ChordQuality.Diminished => $"{Root}dim",
        _ => Root
    };
}
