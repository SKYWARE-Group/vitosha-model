using Refit;

namespace Skyware.Vitosha.Model.Demo;

public interface IVitoshaClient
{

    [Post("/api/messages")]
    Task<MessageResponse> SendMessage(Message message, [Header("x-api-key")] string apiKey);

    [Get("/api/messages/{id}")]
    Task<MessageResponse> GetMessageStatus(int id, [Header("x-api-key")] string apiKey);

}
