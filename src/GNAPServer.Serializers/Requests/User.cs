namespace GNAPServer.Serializers.Requests;

public class User
{
    public List<SubjectId> SubIds { get; set; }
    public Assertions Assertions { get; set; }
}