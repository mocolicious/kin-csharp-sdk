﻿using Newtonsoft.Json;

// ReSharper disable once CheckNamespace
namespace Kin.Marketplace.Models
{
    public class Offer
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("title")]
        public string Title { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("image")]
        public string Image { get; private set; }

        [JsonProperty("amount")]
        public double Amount { get; private set; }

        [JsonProperty("blockchain_data")]
        public BlockChainData BlockChainData { get; private set; }

        [JsonProperty("content")]
        public string Content { get; private set; }

        [JsonProperty("offer_type")]
        public string OfferType { get; private set; }

        [JsonProperty("content_type")]
        public string ContentType { get; private set; }
    }
}