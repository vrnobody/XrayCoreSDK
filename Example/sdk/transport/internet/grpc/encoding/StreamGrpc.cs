// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: transport/internet/grpc/encoding/stream.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Xray.Transport.Internet.Grpc.Encoding {
  public static partial class GRPCService
  {
    static readonly string __ServiceName = "xray.transport.internet.grpc.encoding.GRPCService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Xray.Transport.Internet.Grpc.Encoding.Hunk> __Marshaller_xray_transport_internet_grpc_encoding_Hunk = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Xray.Transport.Internet.Grpc.Encoding.Hunk.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Xray.Transport.Internet.Grpc.Encoding.MultiHunk> __Marshaller_xray_transport_internet_grpc_encoding_MultiHunk = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Xray.Transport.Internet.Grpc.Encoding.MultiHunk.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Xray.Transport.Internet.Grpc.Encoding.Hunk, global::Xray.Transport.Internet.Grpc.Encoding.Hunk> __Method_Tun = new grpc::Method<global::Xray.Transport.Internet.Grpc.Encoding.Hunk, global::Xray.Transport.Internet.Grpc.Encoding.Hunk>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "Tun",
        __Marshaller_xray_transport_internet_grpc_encoding_Hunk,
        __Marshaller_xray_transport_internet_grpc_encoding_Hunk);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Xray.Transport.Internet.Grpc.Encoding.MultiHunk, global::Xray.Transport.Internet.Grpc.Encoding.MultiHunk> __Method_TunMulti = new grpc::Method<global::Xray.Transport.Internet.Grpc.Encoding.MultiHunk, global::Xray.Transport.Internet.Grpc.Encoding.MultiHunk>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "TunMulti",
        __Marshaller_xray_transport_internet_grpc_encoding_MultiHunk,
        __Marshaller_xray_transport_internet_grpc_encoding_MultiHunk);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Xray.Transport.Internet.Grpc.Encoding.StreamReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GRPCService</summary>
    [grpc::BindServiceMethod(typeof(GRPCService), "BindService")]
    public abstract partial class GRPCServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task Tun(grpc::IAsyncStreamReader<global::Xray.Transport.Internet.Grpc.Encoding.Hunk> requestStream, grpc::IServerStreamWriter<global::Xray.Transport.Internet.Grpc.Encoding.Hunk> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task TunMulti(grpc::IAsyncStreamReader<global::Xray.Transport.Internet.Grpc.Encoding.MultiHunk> requestStream, grpc::IServerStreamWriter<global::Xray.Transport.Internet.Grpc.Encoding.MultiHunk> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GRPCService</summary>
    public partial class GRPCServiceClient : grpc::ClientBase<GRPCServiceClient>
    {
      /// <summary>Creates a new client for GRPCService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public GRPCServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GRPCService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public GRPCServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected GRPCServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected GRPCServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Xray.Transport.Internet.Grpc.Encoding.Hunk, global::Xray.Transport.Internet.Grpc.Encoding.Hunk> Tun(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Tun(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Xray.Transport.Internet.Grpc.Encoding.Hunk, global::Xray.Transport.Internet.Grpc.Encoding.Hunk> Tun(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_Tun, null, options);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Xray.Transport.Internet.Grpc.Encoding.MultiHunk, global::Xray.Transport.Internet.Grpc.Encoding.MultiHunk> TunMulti(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return TunMulti(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Xray.Transport.Internet.Grpc.Encoding.MultiHunk, global::Xray.Transport.Internet.Grpc.Encoding.MultiHunk> TunMulti(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_TunMulti, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override GRPCServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GRPCServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(GRPCServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Tun, serviceImpl.Tun)
          .AddMethod(__Method_TunMulti, serviceImpl.TunMulti).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GRPCServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Tun, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Xray.Transport.Internet.Grpc.Encoding.Hunk, global::Xray.Transport.Internet.Grpc.Encoding.Hunk>(serviceImpl.Tun));
      serviceBinder.AddMethod(__Method_TunMulti, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Xray.Transport.Internet.Grpc.Encoding.MultiHunk, global::Xray.Transport.Internet.Grpc.Encoding.MultiHunk>(serviceImpl.TunMulti));
    }

  }
}
#endregion
