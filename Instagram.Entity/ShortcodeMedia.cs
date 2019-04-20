using System.Collections.Generic;
using Newtonsoft.Json;

namespace Instagram.Entity
{
    public class ShortcodeMedia
    {
        [JsonProperty("__typename")]
        public string Typename { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("shortcode")]
        public string Shortcode { get; set; }

        [JsonProperty("dimensions")]
        public Dimensions Dimensions { get; set; }

        [JsonProperty("media_preview")]
        public string MediaPreview { get; set; }

        [JsonProperty("display_url")]
        public string DisplayUrl { get; set; }

        [JsonProperty("display_resources")]
        public List<DisplayResource> DisplayResources { get; set; }

        [JsonProperty("is_video")]
        public bool IsVideo { get; set; }

        [JsonProperty("should_log_client_event")]
        public bool ShouldLogClientEvent { get; set; }

        [JsonProperty("tracking_token")]
        public string TrackingToken { get; set; }

        [JsonProperty("caption_is_edited")]
        public bool CaptionIsEdited { get; set; }

        [JsonProperty("has_ranked_comments")]
        public bool HasRankedComments { get; set; }

        [JsonProperty("comments_disabled")]
        public bool CommentsDisabled { get; set; }

        [JsonProperty("taken_at_timestamp")]
        public int TakenAtTimestamp { get; set; }

        [JsonProperty("viewer_has_liked")]
        public bool ViewerHasLiked { get; set; }

        [JsonProperty("viewer_has_saved")]
        public bool ViewerHasSaved { get; set; }

        [JsonProperty("viewer_has_saved_to_collection")]
        public bool ViewerHasSavedToCollection { get; set; }

        [JsonProperty("viewer_in_photo_of_you")]
        public bool ViewerInPhotoOfYou { get; set; }

        [JsonProperty("viewer_can_reshare")]
        public bool ViewerCanReshare { get; set; }

        [JsonProperty("is_ad")]
        public bool IsAd { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("owner")]
        public Owner Owner { get; set; }

        [JsonProperty("edge_media_to_caption")]
        public EdgeMediaToCaption EdgeMediaToCaption { get; set; }

        [JsonProperty("edge_media_to_comment")]
        public EdgeMediaToComment EdgeMediaToComment { get; set; }

        [JsonProperty("edge_media_preview_like")]
        public EdgeMediaPreviewLike EdgeMediaPreviewLike { get; set; }

        [JsonProperty("edge_sidecar_to_children")]
        public EdgeSidecarToChildren EdgeSidecarToChildren { get; set; }
    }
}
