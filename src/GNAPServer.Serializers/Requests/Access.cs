namespace GNAPServer.Serializers.Requests;

public class Access
{
    public string Type { get; set; }
    public List<string> Actions { get; set; }
    public List<string> Locations { get; set; }
    public List<string> Datatypes { get; set; }
}