namespace Skyware.Vitosha.Model;

/// <summary>
/// Represents a response to message sending.
/// </summary>
public class MessageResponse
{

    /// <summary>
    /// Status code.
    /// </summary>
    public int StatusCode { get; set; }

    /// <summary>
    /// Status message.
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Original message.
    /// </summary>
    public Message MessageObj { get; set; }


    /// <summary>
    /// Message Id.
    /// </summary>
    public int? MessageId { get; set; }

    /// <summary>
    /// Details.
    /// </summary>
    public string Details { get; set; }

}
