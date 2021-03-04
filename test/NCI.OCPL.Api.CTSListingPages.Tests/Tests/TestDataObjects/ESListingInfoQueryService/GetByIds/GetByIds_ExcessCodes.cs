namespace NCI.OCPL.Api.CTSListingPages.Tests
{
    /// <summary>
    /// Test for a request with more c-codes than are in the response.
    /// </summary>
    class GetByIds_ExcessCodes : GetByIds_BaseScenario
    {
        // C12345 is "extra"
        public override string[] InputCCodes => new string[] { "C115270", "C8578", "C9092", "C3017", "C12345"};

        public override string MockESResponse => @"
{
    ""took"": 20,
    ""timed_out"": false,
    ""_shards"": {
        ""total"": 1,
        ""successful"": 1,
        ""skipped"": 0,
        ""failed"": 0
    },
    ""hits"": {
        ""total"": 1,
        ""max_score"": 2.2335923,
        ""hits"": [
            {
                ""_index"": ""listinginfov1"",
                ""_type"": ""ListingInfo"",
                ""_id"": ""AXUtWHSZPZ7BGoClhnsQ"",
                ""_score"": 2.2335923,
                ""_source"": {
                    ""type"": ""OverrideRecord"",
                    ""concept_id"": [
                        ""C115270"",
                        ""C8578"",
                        ""C9092"",
                        ""C3017""
                    ],
                    ""name"": {
                        ""label"": ""Ependymoma"",
                        ""normalized"": ""ependymoma""
                    },
                    ""pretty_url_name"": ""ependymoma""
                }
            }
        ]
    }
}";

        public override ListingInfo[] ExpectedData => null;
    }
}
