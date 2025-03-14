using Newtonsoft.Json.Linq;

namespace GNAPServer.Serializers.Requests;

public class Key
{
    public string Proof { get; set; }
    public Jwk Jwk { get; set; }
}