namespace Core.Config;

public sealed class TestSettings
{
    public string Browser { get; init; } = "chrome";
    public int ViewportWidth { get; init; } = 1440;
    public int ViewportHeight { get; init; } = 900;
}
