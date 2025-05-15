using Refit;

namespace Skyware.Vitosha.Model.Demo;

/// <summary>
/// API client for Vitosha SMS service.
/// </summary>
public interface IVitoshaClient
{

    /// <summary>
    /// Sends a message to the Vitosha SMS service.
    /// </summary>
    /// <param name="message">The message to be sent</param>
    /// <param name="apiKey">API Key</param>
    /// <returns></returns>
    [Post("/api/messages")]
    Task<MessageResponse> SendMessage(Message message, [Header("x-api-key")] string apiKey);

    /// <summary>
    /// Checks the status of a message by its ID.
    /// </summary>
    /// <param name="id">ID of the message assigned by the service</param>
    /// <param name="apiKey">API Key</param>
    /// <returns></returns>
    [Get("/api/messages/{id}")]
    Task<MessageResponse> GetMessageStatus(int id, [Header("x-api-key")] string apiKey);

}
