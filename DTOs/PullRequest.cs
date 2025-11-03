
using System.Text.Json.Serialization;

namespace GithubUserSearchCLI.DTOs;

public record PullRequest(
    [property: JsonPropertyName("url")] string Url,
    [property: JsonPropertyName("id")] object Id,
    [property: JsonPropertyName("number")] int? Number,
    [property: JsonPropertyName("head")] Head Head,
    [property: JsonPropertyName("base")] Base Base
);
