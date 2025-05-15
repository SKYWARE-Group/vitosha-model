namespace Skyware.Vitosha.Model;

public class MessageStatus
{

    public int Id { get; set; }

    public int Service { get; set; }

    public string SmsId { get; set; }

    public int Status { get; set; }

    public DateTime? Sent { get; set; }

}
