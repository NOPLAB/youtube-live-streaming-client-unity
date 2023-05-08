#nullable enable
using System;
using Newtonsoft.Json;

namespace Mochineko.YouTubeLiveStreamingClient.Responses
{
    [JsonObject]
    public sealed class VideoSnippet
    {
        [JsonProperty("publishedAt"), JsonRequired]
        public DateTime PublishedAt { get; private set; }

        [JsonProperty("channelId"), JsonRequired]
        public string ChannelId { get; private set; } = string.Empty;

        [JsonProperty("title"), JsonRequired]
        public string Title { get; private set; } = string.Empty;

        [JsonProperty("description"), JsonRequired]
        public string Description { get; private set; } = string.Empty;

        [JsonProperty("thumbnails"), JsonRequired]
        public VideoThumbnails Thumbnails { get; private set; } = new();

        [JsonProperty("channelTitle"), JsonRequired]
        public string ChannelTitle { get; private set; } = string.Empty;

        [JsonProperty("tags"), JsonRequired]
        public string[] Tags { get; private set; } = Array.Empty<string>();

        [JsonProperty("categoryId"), JsonRequired]
        public string CategoryId { get; private set; } = string.Empty;
    }
}