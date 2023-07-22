#nullable enable
using Newtonsoft.Json;

namespace Mochineko.YouTubeLiveStreamingClient.Responses
{
    [JsonObject]
    public sealed class VideoThumbnails
    {
        [JsonProperty("default"), JsonRequired]
        public VideoThumbnail Default { get; private set; } = new();

        [JsonProperty("medium"), JsonRequired]
        public VideoThumbnail Medium { get; private set; } = new();

        [JsonProperty("high"), JsonRequired]
        public VideoThumbnail High { get; private set; } = new();
        
        [JsonProperty("standard"), JsonRequired]
        public VideoThumbnail Standard { get; private set; } = new();
        
        [JsonProperty("maxres")]
        public VideoThumbnail Maxres { get; private set; } = new();
    }
}