using System.Text.Json.Serialization;

namespace Polymarket.Net.Objects.Models
{
    /// <summary>
    /// Price change update
    /// </summary>
    public record PolymarketBookUpdate : PolymarketSocketUpdate
    {
        /// <summary>
        /// Market id
        /// </summary>
        [JsonPropertyName("market")]
        public string Market { get; set; } = string.Empty;
        /// <summary>
        /// Asset id
        /// </summary>
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; } = string.Empty;
        /// <summary>
        /// Hash
        /// </summary>
        [JsonPropertyName("hash")]
        public string Hash { get; set; } = string.Empty;
        /// <summary>
        /// Last trade price
        /// </summary>
        [JsonPropertyName("last_trade_price")]
        public decimal? LastTradePrice { get; set; }
        /// <summary>
        /// Bids
        /// </summary>
        [JsonPropertyName("bids")]
        public PolymarketBookEntry[] Bids { get; set; } = [];
        /// <summary>
        /// Asks
        /// </summary>
        [JsonPropertyName("asks")]
        public PolymarketBookEntry[] Asks { get; set; } = [];
    }
}
