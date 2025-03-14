namespace GNAPServer.Serializers.Requests;

public class Jwk
{
    public string Kty { get; set; }
    public string E { get; set; }
    public string N { get; set; }
    public string X { get; set; }
    public string Y { get; set; }
    public string Crv { get; set; }
    public string Kid { get; set; }
    public string Use { get; set; }
}