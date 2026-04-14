namespace GuitarChordExplorer.Models;

public class ScaleInfo
{
    public required string Name        { get; init; }
    public required string[] Notes     { get; init; }
    public required string Pattern     { get; init; }
    public required string Description { get; init; }
}
