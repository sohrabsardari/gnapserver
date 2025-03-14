using GNAPServer.Serializers.Requests;
using Newtonsoft.Json;

namespace GNAPServer.Serializers.Tests.Unit
{
    public class RequestTests
    {
        [Fact]
        public void Request_from_client_to_authorization_server_tests()
        {
            var aa = JsonConvert.DeserializeObject<ClientToAuthorizationServerRequest>(RequestJsonSampleJson.GetFullRequest());

        }
    }

    internal static class RequestJsonSampleJson
    {
        internal static string GetFullRequest()
        {
            return @"{
    ""access_token"": {
        ""access"": [
            {
                ""type"": ""example.com/resource-set"",
                ""actions"": [
                    ""read"",
                    ""write"",
                    ""dolphin""
                ],
                ""locations"": [
                    ""https://server.example.net/"",
                    ""https://resource.local/other""
                ],
                ""datatypes"": [
                    ""metadata"",
                    ""images""
                ]
            }
        ]
    },
    ""subject"": {
        ""sub-ids"": [
            ""iss-sub"",
            ""email"",
            ""phone""
        ],
        ""assertions"": [
            ""oidc_id_token"",
            ""verfiable-credential""
        ]
    },
    ""client"": {
        ""key"": {
            ""proof"": ""httpsig"",
            ""jwk"": {
                ""kty"": ""RSA"",
                ""e"": ""AQAB"",
                ""kid"": ""xyz-1"",
                ""alg"": ""RS256"",
                ""n"": ""kOB5rR4Jv0GMeLaY6_It_r3ORwdf8ci_JtffXyaSx8xYJCCNaOKNJn_Oz0YhdHbXTeWO5AoyspDWJbN5w_7bdWDxgpD-y6jnD1u9YhBOCWObNPFvpkTM8LC7SdXGRKx2k8Me2r_GssYlyRpqvpBlY5-ejCywKRBfctRcnhTTGNztbbDBUyDSWmFMVCHe5mXT4cL0BwrZC6S-uu-LAx06aKwQOPwYOGOslK8WPm1yGdkaA1uF_FpS6LS63WYPHi_Ap2B7_8Wbw4ttzbMS_doJvuDagW8A1Ip3fXFAHtRAcKw7rdI4_Xln66hJxFekpdfWdiPQddQ6Y1cK2U3obvUg7w""
            }
        },
        ""display"": {
            ""name"": ""My Client Display Name"",
            ""uri"": ""https://example.net/client""
        }
    },
    ""interact"": {
        ""start"": [
            ""app"",
            ""user_code"",
            ""redirect""
        ],
        ""finish"": {
            ""method"": ""redirect"",
            ""uri"": ""https://client.example.net/return/123455"",
            ""nonce"": ""LKLTI25DK82FX4T4QFZC""
        }
    },
    ""user"": {
        ""sub_ids"": [
            {
                ""subject_type"": ""email"",
                ""email"": ""user@example.com""
            }
        ],
        ""assertions"": {
            ""oidc-id-token"": ""eyJraWQiOiIxZTlnZGs3IiwiYWxnIjoiUlMyNTYifQ.ewogImlzcyI6ICJodHRwOi8vc2VydmVyLmV4YW1wbGUuY29tIiwKICJzdWIiOiAiMjQ4Mjg5NzYxMDAxIiwKICJhdWQiOiAiczZCaGRSa3F0MyIsCiAibm9uY2UiOiAibi0wUzZfV3pBMk1qIiwKICJleHAiOiAxMzExMjgxOTcwLAogImlhdCI6IDEzMTEyODA5NzAsCiAibmFtZSI6ICJKYW5lIERvZSIsCiAiZ2l2ZW5fbmFtZSI6ICJKYW5lIiwKICJmYW1pbHlfbmFtZSI6ICJEb2UiLAogImdlbmRlciI6ICJmZW1hbGUiLAogImJpcnRoZGF0ZSI6ICIwMDAwLTEwLTMxIiwKICJlbWFpbCI6ICJqYW5lZG9lQGV4YW1wbGUuY29tIiwKICJwaWN0dXJlIjogImh0dHA6Ly9leGFtcGxlLmNvbS9qYW5lZG9lL21lLmpwZyIKfQ.rHQjEmBqn9Jre0OLykYNnspA10Qql2rvx4FsD00jwlB0Sym4NzpgvPKsDjn_wMkHxcp6CilPcoKrWHcipR2iAjzLvDNAReF97zoJqq880ZD1bwY82JDauCXELVR9O6_B0w3K-E7yM2macAAgNCUwtik6SjoSUZRcf-O5lygIyLENx882p6MtmwaL1hd6qn5RZOQ0TLrOYu0532g9Exxcm-ChymrB4xLykpDj3lUivJt63eEGGN6DH5K6o33TcxkIjNrCD4XB1CKKumZvCedgHHF3IAK4dVEDSUoGlH9z4pP_eWYNXvqQOjGs-rDaQzUHl6cQQWNiDpWOl_lxXjQEvQ""
        }
    }
}";
        }
    }
}