namespace GuitarChordExplorer.Models;

public class TonePreset
{
    public required string   Genre       { get; init; }
    public required string   Description { get; init; }
    public required string   Color       { get; init; }
    public required string   AmpType     { get; init; }
    public required string   Pickup      { get; init; }
    public required int      Gain        { get; init; }
    public required int      Bass        { get; init; }
    public required int      Mid         { get; init; }
    public required int      Treble      { get; init; }
    public required int      Presence    { get; init; }
    public required int      Reverb      { get; init; }
    public required string[] Effects     { get; init; }
    public required string[] Artists     { get; init; }
}
