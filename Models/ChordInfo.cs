namespace GuitarChordExplorer.Models;

public class ChordInfo
{
    public required string Root { get; init; }
    public required ChordQuality Quality { get; init; }
    public required string RomanNumeral { get; init; }
    public required int ScaleDegree { get; init; }

    public string ChordName => Quality switch
    {
        ChordQuality.Minor => $"{Root}m",
        ChordQuality.Diminished => $"{Root}dim",
        _ => Root
    };

    public string QualityLabel => Quality switch
    {
        ChordQuality.Minor => "minor",
        ChordQuality.Diminished => "diminished",
        _ => "major"
    };
}
