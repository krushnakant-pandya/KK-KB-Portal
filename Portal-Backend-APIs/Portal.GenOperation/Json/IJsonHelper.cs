namespace Portal.GenOperation.Json;

/// <summary>Thin wrapper over System.Text.Json with standard options — used by AuditService callers to serialize old/new entity values, and anywhere else ad-hoc (de)serialization is needed outside the ASP.NET Core request pipeline.</summary>
public interface IJsonHelper
{
    string Serialize<T>(T value);

    T? Deserialize<T>(string json);
}
