namespace GNAPServer.Serializers.Requests;

public class Finish
{
    public string Method { get; set; }
    public string Uri { get; set; }
    public string Nonce { get; set; }
}