
using System.Text.Json.Serialization;

namespace GithubUserSearchCLI.DTOs;

public record Event(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("actor")] Actor Actor,
    [property: JsonPropertyName("repo")] Repo Repo,
    [property: JsonPropertyName("payload")] Payload Payload,
    [property: JsonPropertyName("public")] bool? Public,
    [property: JsonPropertyName("created_at")] DateTime? CreatedAt
);
