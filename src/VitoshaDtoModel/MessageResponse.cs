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

    public Message MessageObj { get; set; }

    public int? MessageId { get; set; }

    public string Details { get; set; }

}
