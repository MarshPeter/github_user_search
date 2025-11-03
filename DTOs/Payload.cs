
using System.Text.Json.Serialization;

namespace GithubUserSearchCLI.DTOs;

public record Payload(
    [property: JsonPropertyName("repository_id")] int? RepositoryId,
    [property: JsonPropertyName("push_id")] object PushId,
    [property: JsonPropertyName("ref")] string Ref,
    [property: JsonPropertyName("head")] string Head,
    [property: JsonPropertyName("before")] string Before,
    [property: JsonPropertyName("ref_type")] string RefType,
    [property: JsonPropertyName("full_ref")] string FullRef,
    [property: JsonPropertyName("master_branch")] string MasterBranch,
    [property: JsonPropertyName("description")] object Description,
    [property: JsonPropertyName("pusher_type")] string PusherType,
    [property: JsonPropertyName("action")] string Action,
    [property: JsonPropertyName("number")] int? Number,
    [property: JsonPropertyName("pull_request")] PullRequest PullRequest
);
