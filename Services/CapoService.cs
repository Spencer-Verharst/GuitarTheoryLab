namespace GuitarChordExplorer.Services;

using GuitarChordExplorer.Models;

public class CapoService
{
    public static readonly string[] Chromatic =
        ["C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "Bb", "B"];

    private static readonly string[] OpenKeys = ["E", "A", "D", "G", "C"];

    public static readonly string[] ShapeKeys = ["E", "A", "D", "G", "C"];

    public CapoInfo GetCapo(string targetKey)
    {
        int targetIdx = Array.IndexOf(Chromatic, targetKey);

        string bestGuitarKey = OpenKeys[0];
        int bestFret = 12;

        foreach(var openKey in OpenKeys)
        {
            int openIdx = Array.IndexOf(Chromatic, openKey);
            int fret = (targetIdx - openIdx + 12) % 12;

            if(fret < bestFret)
            {
                bestFret = fret;
                bestGuitarKey = openKey;
            }
        }

        return new CapoInfo
        {
            TargetKey = targetKey,
            CapoFret = bestFret,
            GuitarKey = bestGuitarKey
        };
    }

    public int GetCapoFret(string targetKey, string shapeKey)
    {
        int targetIdx = Array.IndexOf(Chromatic, targetKey);
        int shapeIdx  = Array.IndexOf(Chromatic, shapeKey);
        return (targetIdx - shapeIdx + 12) % 12;
    }
}