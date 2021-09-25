namespace MobileDev05.API.Services
{
    public interface IJsonSerializeService
    {
        string Serialize(object payload);

        T Deserialize<T>(string payload);
    }
}
