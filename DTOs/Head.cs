
using System.Text.Json.Serialization;

namespace GithubUserSearchCLI.DTOs;

public record Head(
    [property: JsonPropertyName("ref")] string Ref,
    [property: JsonPropertyName("sha")] string Sha,
    [property: JsonPropertyName("repo")] Repo Repo
);
