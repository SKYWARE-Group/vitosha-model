namespace Skyware.Vitosha.Model;

/// <summary>
/// Represents a message to be sent via Vitosha SMS service.
/// </summary>
public class Message
{

    /// <summary>
    /// Is the message intended for viber
    /// </summary>
    public bool IsViber { get; set; } = false;

    /// <summary>
    /// Receiver's MSISDN
    /// </summary>
    public string Recipient { get; set; }

    /// <summary>
    /// Text of the SMS Message.
    /// </summary>
    public string Text { get; set; } = string.Empty;

    /// <summary>
    /// Viber Button Text 
    /// </summary>
    public string ButtonName { get; set; }

    /// <summary>
    /// Viber Button URL
    /// </summary>
    public string ButtonUrl { get; set; }

    /// <summary>
    /// Viber Image URL
    /// </summary>
    public string ImageUrl { get; set; }

    /// <summary>
    /// Reference Id
    /// </summary>
    public string RefId { get; set; }

    /// <summary>
    /// Reference Id
    /// </summary>
    public string Note { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public MessageStatus[] Statuses { get; set; }

}
