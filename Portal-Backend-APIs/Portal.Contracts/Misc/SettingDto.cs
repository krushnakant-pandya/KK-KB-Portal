namespace Portal.Contracts.Misc;

public sealed class SettingDto
{
    public string SettingKey { get; init; } = string.Empty;
    public string? SettingValue { get; init; }
    public DateTime UpdatedAt { get; init; }
}
