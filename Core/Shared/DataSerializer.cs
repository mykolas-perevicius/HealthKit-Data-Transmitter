using MessagePack; // Install MessagePack-CSharp from NuGet

namespace Shared
{
    public class DataSerializer
    {
        public byte[] SerializeHealthData(object healthData)
        {
            return MessagePackSerializer.Serialize(healthData);
        }

        // ... Add a deserialize method
    }
}
