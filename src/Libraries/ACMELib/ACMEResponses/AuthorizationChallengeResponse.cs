﻿namespace Kenc.ACMELib.ACMEResponses
{
    using System;
    using Kenc.ACMELib.ACMEEntities;
    using Newtonsoft.Json;

    /// <summary>
    /// Describes an authorization challenge response in the ACME protocol.
    /// </summary>
    public class AuthorizationChallengeResponse : ILocationResponse
    {
        [JsonProperty("identifier")]
        public OrderIdentifier Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("expires")]
        public DateTime? Expires { get; set; }

        [JsonProperty("wildcard")]
        public bool Wildcard { get; set; }

        [JsonProperty("challenges")]
        public AuthorizationChallenge[] Challenges { get; set; }

        [JsonIgnore]
        public Uri Location { get; set; }
    }
}