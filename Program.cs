using GuitarChordExplorer.Components;
using GuitarChordExplorer.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<MusicTheoryService>();
builder.Services.AddSingleton<ChordLibraryService>();
builder.Services.AddSingleton<ScaleService>();
builder.Services.AddSingleton<ToneService>();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
