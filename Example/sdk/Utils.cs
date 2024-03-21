using Google.Protobuf;

namespace Xray
{
    public static partial class Utils
    {
        public static string GetMessageTypeName<T>(T message)
            where T : IMessage<T>
        {
            var ps = message.GetType()?.FullName?.Split(".");
            if (ps == null || ps.Length < 1)
            {
                throw new ArgumentNullException("Message type is null!");
            }

            for (int i = 0; i < ps.Length - 1; i++)
            {
                ps[i] = ps[i].ToLower();
            }

            return string.Join(".", ps);
        }

        public static Common.Serial.TypedMessage ToTypedMessage<T>(T message)
            where T : IMessage<T>
        {
            if (message == null)
            {
                throw new ArgumentNullException("Message is null!");
            }

            return new Common.Serial.TypedMessage()
            {
                Type = GetMessageTypeName(message),
                Value = message.ToByteString(),
            };
        }
    }
}
