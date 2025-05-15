namespace Skyware.Vitosha.Model;

/// <summary>
/// Callback message from Vitosha SMS service.
/// </summary>
public class CallbackMessage
{

    /// <summary>
    /// Unique identifier for the message.
    /// </summary>
    public int MessageId { get; set; }

    /// <summary>
    /// Status of the message.
    /// </summary>
    public int Status { get; set; }

    /// <summary>
    /// Reference ID for the message as it is sent from the client.
    /// </summary>
    public string RefId { get; set; }

    /// <summary>
    /// Note or additional information about the message status.
    /// </summary>
    public string Note { get; set; }

}
