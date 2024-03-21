using Grpc.Net.Client;

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

        private static Xray.Common.Serial.TypedMessage CreateVlessSettings()
        {
            var user = new Xray.Common.Protocol.User()
            {
                Account = Xray.Utils.ToTypedMessage(
                    new Xray.Proxy.Vless.Account()
                    {
                        Encryption = "none",
                        Id = Guid.NewGuid().ToString(),
                    }
                ),
            };

            var serv = new Xray.Common.Protocol.ServerEndpoint()
            {
                Address = new Xray.Common.Net.IPOrDomain() { Domain = "bing.com", },
                Port = 1234,
            };
            serv.User.Add(user);

            var vless = new Xray.Proxy.Vless.Outbound.Config();
            vless.Vnext.Add(serv);

            return Xray.Utils.ToTypedMessage(vless);
        }

        static Xray.Common.Serial.TypedMessage CreateStreamSettings()
        {
            var tcp = new Xray.Transport.Internet.TransportConfig()
            {
                ProtocolName = "tcp",
                Settings = Xray.Utils.ToTypedMessage(new Xray.Transport.Internet.Tcp.Config()),
            };

            var reality = Xray.Utils.ToTypedMessage(
                new Xray.Transport.Internet.Reality.Config() { ServerName = "bing.com", }
            );

            var stream = new Xray.Transport.Internet.StreamConfig()
            {
                ProtocolName = "tcp",
                SecurityType = Xray.Utils.GetMessageTypeName(reality),
            };

            stream.TransportSettings.Add(tcp);
            stream.SecuritySettings.Add(reality);

            return Xray.Utils.ToTypedMessage(
                new Xray.App.Proxyman.SenderConfig() { StreamSettings = stream, }
            );
        }
    }
}
