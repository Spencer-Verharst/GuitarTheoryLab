# Guitar Theory Lab

A Blazor Server web app for guitarists who want to understand music theory on the fretboard — no capo required.

## Features

**Chord Explorer**
- Pick any major or minor key and see all 7 diatonic chords
- SVG fretboard diagrams for every chord with barre chord support
- Quick reference table showing each chord's role in the key (tonic, dominant, etc.)

**Scale Explorer**
- Pick any root note and see 7 essential scales: Major, Natural Minor, Major/Minor Pentatonic, Blues, Dorian, and Mixolydian
- Horizontal fretboard diagrams showing where to play each note
- Interval patterns and descriptions for each scale

**Tone Settings**
- Amp and EQ presets for 7 genres: Clean/Funk, Country, Blues, Classic Rock, Hard Rock/Metal, Jazz, and Alternative/Indie
- Visual knob dials for Gain, Bass, Mid, Treble, Presence, and Reverb
- Effects chain and artist references for each genre

## Tech Stack

- [.NET 9](https://dotnet.microsoft.com/) — Blazor Server
- C# with Razor components
- SVG for all fretboard and knob diagrams
- Bootstrap for layout

## Running Locally

1. Clone the repo
2. Make sure [.NET 9 SDK](https://dotnet.microsoft.com/download) is installed
3. Run the app:

```bash
dotnet run --launch-profile http
```

4. Open your browser to `http://localhost:5294`
