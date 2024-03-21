using Grpc.Net.Client;
using Xray;

namespace Example
{
    internal class Program
    {
        static void Main(string[] _)
        {
            var url = "http://localhost:10085";

            var vless = CreateVlessSettings();
            var stream = CreateStreamSettings();
            var req = new Xray.App.Proxyman.Command.AddOutboundRequest()
            {
                Outbound = new Xray.Core.OutboundHandlerConfig()
                {
                    Tag = "grpc-test",
                    ProxySettings = vless,
                    SenderSettings = stream,
                },
            };

            var channel = GrpcChannel.ForAddress(url);
            var client = new Xray.App.Proxyman.Command.HandlerService.HandlerServiceClient(channel);
            var resp = client.AddOutbound(req);
            Console.WriteLine($"response: {resp}");
        }

        static Xray.Common.Serial.TypedMessage CreateVlessSettings()
        {
            var user = new Xray.Common.Protocol.User()
            {
                Account = new Xray.Proxy.Vless.Account()
                {
                    Encryption = "none",
                    Id = Guid.NewGuid().ToString(),
                }.ToTypedMessage(),
            };

            var serv = new Xray.Common.Protocol.ServerEndpoint()
            {
                Address = new Xray.Common.Net.IPOrDomain() { Domain = "bing.com", },
                Port = 1234,
            };
            serv.User.Add(user);

            var vless = new Xray.Proxy.Vless.Outbound.Config();
            vless.Vnext.Add(serv);

            return vless.ToTypedMessage();
        }

        static Xray.Common.Serial.TypedMessage CreateStreamSettings()
        {
            var transport = "tcp";

            var tcp = new Xray.Transport.Internet.TransportConfig()
            {
                ProtocolName = transport,
                Settings = new Xray.Transport.Internet.Tcp.Config().ToTypedMessage(),
            };

            var reality = new Xray.Transport.Internet.Reality.Config()
            {
                ServerName = "bing.com",
            }.ToTypedMessage();

            var stream = new Xray.Transport.Internet.StreamConfig()
            {
                ProtocolName = transport,
                SecurityType = reality.GetMessageTypeName(),
            };

            stream.TransportSettings.Add(tcp);
            stream.SecuritySettings.Add(reality);

            return new Xray.App.Proxyman.SenderConfig()
            {
                StreamSettings = stream,
            }.ToTypedMessage();
        }
    }
}
