namespace Skyware.Vitosha.Model;

public class SkywareResponse
{

    public SkywareResponse() { }

    public SkywareResponse(int statusCode, string message)
    {
        StatusCode = statusCode;
        Message = message;
    }

    public SkywareResponse(int statusCode, string message, int messageId)
    {
        StatusCode = statusCode;
        Message = message;
        MessageId = messageId;
    }

    public SkywareResponse(int statusCode, string message, string details)
    {
        StatusCode = statusCode;
        Message = message;
        Details = details;
    }

    public SkywareResponse(int statusCode, string message, Message messageObj)
    {
        StatusCode = statusCode;
        Message = message;
        MessageObj = messageObj;
    }

    public int StatusCode { get; set; }

    public string Message { get; set; }

    public Message MessageObj { get; set; }

    public int? MessageId { get; set; }

    public string Details { get; set; }

}
