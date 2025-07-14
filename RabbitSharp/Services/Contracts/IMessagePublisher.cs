namespace RabbitSharp.Services.Contracts;

public interface IMessagePublisher
{
    Task PublishAsync<T>(T message);
}