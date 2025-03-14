using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GNAPServer.Serializers.Requests
{
    public class ClientToAuthorizationServerRequest
    {
        [JsonProperty("access_token")]
        [JsonConverter(typeof(SingleValueArrayConverter<AccessToken>))]
        public List<AccessToken> AccessToken { get; set; }
        public Subject Subject { get; set; }
        public Client Client { get; set; }
        public Interact Interact { get; set; }
        public User User { get; set; }
    }
}
