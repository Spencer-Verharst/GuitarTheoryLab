namespace GuitarChordExplorer.Services;

using GuitarChordExplorer.Models;

public class ToneService
{
    public static IReadOnlyList<TonePreset> Presets { get; } =
    [
        new TonePreset
        {
            Genre       = "Clean / Funk",
            Description = "Crisp, glassy tone with plenty of headroom. Strings pop and chords sparkle. The foundation of funk, R&B, and soul.",
            Color       = "#10b981",
            AmpType     = "Fender Twin Reverb or Roland Jazz Chorus",
            Pickup      = "Neck single-coil (Stratocaster or Telecaster)",
            Gain        = 1,
            Bass        = 4,
            Mid         = 6,
            Treble      = 7,
            Presence    = 6,
            Reverb      = 4,
            Effects     = ["Compressor (always on)", "Chorus (subtle)", "Light Reverb"],
            Artists     = ["Nile Rodgers", "Stevie Wonder band", "Chic", "Tower of Power"]
        },
        new TonePreset
        {
            Genre       = "Country",
            Description = "Bright, twangy, and cutting. High treble with moderate gain and a touch of reverb gives that classic Nashville sound.",
            Color       = "#f59e0b",
            AmpType     = "Fender Deluxe Reverb or Fender Telecaster through a Fender Princeton",
            Pickup      = "Bridge single-coil (Telecaster is king here)",
            Gain        = 3,
            Bass        = 4,
            Mid         = 5,
            Treble      = 8,
            Presence    = 7,
            Reverb      = 5,
            Effects     = ["Compressor", "Tape Echo / Slap Delay", "Reverb", "Light Overdrive (optional)"],
            Artists     = ["Brad Paisley", "Brent Mason", "Danny Gatton", "Albert Lee"]
        },
        new TonePreset
        {
            Genre       = "Blues",
            Description = "Warm, vocal, and expressive. Pushing the amp into natural breakup gives that crying, singing tone. Dynamics matter — play soft for clean, dig in for grit.",
            Color       = "#3b82f6",
            AmpType     = "Fender Blues Jr., Fender Bassman, or Marshall Bluesbreaker",
            Pickup      = "Neck single-coil or neck humbucker",
            Gain        = 5,
            Bass        = 6,
            Mid         = 7,
            Treble      = 6,
            Presence    = 5,
            Reverb      = 4,
            Effects     = ["Tube Screamer (boost, not heavy distortion)", "Wah", "Reverb"],
            Artists     = ["Stevie Ray Vaughan", "BB King", "Eric Clapton", "Gary Moore"]
        },
        new TonePreset
        {
            Genre       = "Classic Rock",
            Description = "Crunchy rhythm tone with enough gain for sustain but not so much it gets muddy. Big, warm, and punchy.",
            Color       = "#ef4444",
            AmpType     = "Marshall JMP/JCM, Vox AC30, or Fender Bassman",
            Pickup      = "Bridge humbucker (Les Paul or SG)",
            Gain        = 6,
            Bass        = 6,
            Mid         = 6,
            Treble      = 7,
            Presence    = 7,
            Reverb      = 3,
            Effects     = ["Light to moderate distortion", "Wah (for leads)", "Tape Delay"],
            Artists     = ["Jimmy Page", "Angus Young", "Jimi Hendrix", "Carlos Santana"]
        },
        new TonePreset
        {
            Genre       = "Hard Rock / Metal",
            Description = "Tight, aggressive, and saturated. Scoop the mids for modern metal, keep them for classic hard rock. Tight bass response is critical.",
            Color       = "#6b7280",
            AmpType     = "Mesa Boogie Rectifier, Marshall JCM 800, or Peavey 5150",
            Pickup      = "Bridge humbucker — high output (EMG, Seymour Duncan Invader)",
            Gain        = 9,
            Bass        = 7,
            Mid         = 3,
            Treble      = 8,
            Presence    = 8,
            Reverb      = 1,
            Effects     = ["Heavy distortion / high gain amp channel", "Noise Gate", "Chorus (leads only)"],
            Artists     = ["Eddie Van Halen", "James Hetfield", "Dimebag Darrell", "Zakk Wylde"]
        },
        new TonePreset
        {
            Genre       = "Jazz",
            Description = "Dark, warm, and round. Virtually no treble or gain — the goal is a smooth, thick tone that sits in the mix without cutting.",
            Color       = "#8b5cf6",
            AmpType     = "Fender Twin (clean), Roland Jazz Chorus, or Gibson GA-40",
            Pickup      = "Neck humbucker (hollow or semi-hollow body guitar ideal)",
            Gain        = 2,
            Bass        = 6,
            Mid         = 7,
            Treble      = 3,
            Presence    = 3,
            Reverb      = 3,
            Effects     = ["Chorus (very subtle)", "Light reverb", "No distortion"],
            Artists     = ["Wes Montgomery", "Joe Pass", "Pat Metheny", "George Benson"]
        },
        new TonePreset
        {
            Genre       = "Alternative / Indie",
            Description = "Jangly, textured, and atmospheric. A blend of clean and slightly driven with heavy use of time-based effects (reverb and delay) to create space.",
            Color       = "#ec4899",
            AmpType     = "Vox AC30, Fender Twin, or Orange Rocker",
            Pickup      = "Neck single-coil or P90",
            Gain        = 4,
            Bass        = 5,
            Mid         = 6,
            Treble      = 6,
            Presence    = 5,
            Reverb      = 7,
            Effects     = ["Chorus", "Long delay (dotted eighth)", "Light overdrive", "Big reverb"],
            Artists     = ["Johnny Marr (The Smiths)", "J Mascis (Dinosaur Jr)", "Kevin Shields (My Bloody Valentine)"]
        },
    ];
}
