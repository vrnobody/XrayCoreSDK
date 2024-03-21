// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: app/proxyman/command/command.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Xray.App.Proxyman.Command {
  public static partial class HandlerService
  {
    static readonly string __ServiceName = "xray.app.proxyman.command.HandlerService";

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
    static readonly grpc::Marshaller<global::Xray.App.Proxyman.Command.AddInboundRequest> __Marshaller_xray_app_proxyman_command_AddInboundRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Xray.App.Proxyman.Command.AddInboundRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Xray.App.Proxyman.Command.AddInboundResponse> __Marshaller_xray_app_proxyman_command_AddInboundResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Xray.App.Proxyman.Command.AddInboundResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Xray.App.Proxyman.Command.RemoveInboundRequest> __Marshaller_xray_app_proxyman_command_RemoveInboundRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Xray.App.Proxyman.Command.RemoveInboundRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Xray.App.Proxyman.Command.RemoveInboundResponse> __Marshaller_xray_app_proxyman_command_RemoveInboundResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Xray.App.Proxyman.Command.RemoveInboundResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Xray.App.Proxyman.Command.AlterInboundRequest> __Marshaller_xray_app_proxyman_command_AlterInboundRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Xray.App.Proxyman.Command.AlterInboundRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Xray.App.Proxyman.Command.AlterInboundResponse> __Marshaller_xray_app_proxyman_command_AlterInboundResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Xray.App.Proxyman.Command.AlterInboundResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Xray.App.Proxyman.Command.AddOutboundRequest> __Marshaller_xray_app_proxyman_command_AddOutboundRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Xray.App.Proxyman.Command.AddOutboundRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Xray.App.Proxyman.Command.AddOutboundResponse> __Marshaller_xray_app_proxyman_command_AddOutboundResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Xray.App.Proxyman.Command.AddOutboundResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Xray.App.Proxyman.Command.RemoveOutboundRequest> __Marshaller_xray_app_proxyman_command_RemoveOutboundRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Xray.App.Proxyman.Command.RemoveOutboundRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Xray.App.Proxyman.Command.RemoveOutboundResponse> __Marshaller_xray_app_proxyman_command_RemoveOutboundResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Xray.App.Proxyman.Command.RemoveOutboundResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Xray.App.Proxyman.Command.AlterOutboundRequest> __Marshaller_xray_app_proxyman_command_AlterOutboundRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Xray.App.Proxyman.Command.AlterOutboundRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Xray.App.Proxyman.Command.AlterOutboundResponse> __Marshaller_xray_app_proxyman_command_AlterOutboundResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Xray.App.Proxyman.Command.AlterOutboundResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Xray.App.Proxyman.Command.AddInboundRequest, global::Xray.App.Proxyman.Command.AddInboundResponse> __Method_AddInbound = new grpc::Method<global::Xray.App.Proxyman.Command.AddInboundRequest, global::Xray.App.Proxyman.Command.AddInboundResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddInbound",
        __Marshaller_xray_app_proxyman_command_AddInboundRequest,
        __Marshaller_xray_app_proxyman_command_AddInboundResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Xray.App.Proxyman.Command.RemoveInboundRequest, global::Xray.App.Proxyman.Command.RemoveInboundResponse> __Method_RemoveInbound = new grpc::Method<global::Xray.App.Proxyman.Command.RemoveInboundRequest, global::Xray.App.Proxyman.Command.RemoveInboundResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RemoveInbound",
        __Marshaller_xray_app_proxyman_command_RemoveInboundRequest,
        __Marshaller_xray_app_proxyman_command_RemoveInboundResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Xray.App.Proxyman.Command.AlterInboundRequest, global::Xray.App.Proxyman.Command.AlterInboundResponse> __Method_AlterInbound = new grpc::Method<global::Xray.App.Proxyman.Command.AlterInboundRequest, global::Xray.App.Proxyman.Command.AlterInboundResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AlterInbound",
        __Marshaller_xray_app_proxyman_command_AlterInboundRequest,
        __Marshaller_xray_app_proxyman_command_AlterInboundResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Xray.App.Proxyman.Command.AddOutboundRequest, global::Xray.App.Proxyman.Command.AddOutboundResponse> __Method_AddOutbound = new grpc::Method<global::Xray.App.Proxyman.Command.AddOutboundRequest, global::Xray.App.Proxyman.Command.AddOutboundResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddOutbound",
        __Marshaller_xray_app_proxyman_command_AddOutboundRequest,
        __Marshaller_xray_app_proxyman_command_AddOutboundResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Xray.App.Proxyman.Command.RemoveOutboundRequest, global::Xray.App.Proxyman.Command.RemoveOutboundResponse> __Method_RemoveOutbound = new grpc::Method<global::Xray.App.Proxyman.Command.RemoveOutboundRequest, global::Xray.App.Proxyman.Command.RemoveOutboundResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RemoveOutbound",
        __Marshaller_xray_app_proxyman_command_RemoveOutboundRequest,
        __Marshaller_xray_app_proxyman_command_RemoveOutboundResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Xray.App.Proxyman.Command.AlterOutboundRequest, global::Xray.App.Proxyman.Command.AlterOutboundResponse> __Method_AlterOutbound = new grpc::Method<global::Xray.App.Proxyman.Command.AlterOutboundRequest, global::Xray.App.Proxyman.Command.AlterOutboundResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AlterOutbound",
        __Marshaller_xray_app_proxyman_command_AlterOutboundRequest,
        __Marshaller_xray_app_proxyman_command_AlterOutboundResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Xray.App.Proxyman.Command.CommandReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of HandlerService</summary>
    [grpc::BindServiceMethod(typeof(HandlerService), "BindService")]
    public abstract partial class HandlerServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Xray.App.Proxyman.Command.AddInboundResponse> AddInbound(global::Xray.App.Proxyman.Command.AddInboundRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Xray.App.Proxyman.Command.RemoveInboundResponse> RemoveInbound(global::Xray.App.Proxyman.Command.RemoveInboundRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Xray.App.Proxyman.Command.AlterInboundResponse> AlterInbound(global::Xray.App.Proxyman.Command.AlterInboundRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Xray.App.Proxyman.Command.AddOutboundResponse> AddOutbound(global::Xray.App.Proxyman.Command.AddOutboundRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Xray.App.Proxyman.Command.RemoveOutboundResponse> RemoveOutbound(global::Xray.App.Proxyman.Command.RemoveOutboundRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Xray.App.Proxyman.Command.AlterOutboundResponse> AlterOutbound(global::Xray.App.Proxyman.Command.AlterOutboundRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for HandlerService</summary>
    public partial class HandlerServiceClient : grpc::ClientBase<HandlerServiceClient>
    {
      /// <summary>Creates a new client for HandlerService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public HandlerServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for HandlerService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public HandlerServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected HandlerServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected HandlerServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Xray.App.Proxyman.Command.AddInboundResponse AddInbound(global::Xray.App.Proxyman.Command.AddInboundRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddInbound(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Xray.App.Proxyman.Command.AddInboundResponse AddInbound(global::Xray.App.Proxyman.Command.AddInboundRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddInbound, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Xray.App.Proxyman.Command.AddInboundResponse> AddInboundAsync(global::Xray.App.Proxyman.Command.AddInboundRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddInboundAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Xray.App.Proxyman.Command.AddInboundResponse> AddInboundAsync(global::Xray.App.Proxyman.Command.AddInboundRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddInbound, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Xray.App.Proxyman.Command.RemoveInboundResponse RemoveInbound(global::Xray.App.Proxyman.Command.RemoveInboundRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RemoveInbound(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Xray.App.Proxyman.Command.RemoveInboundResponse RemoveInbound(global::Xray.App.Proxyman.Command.RemoveInboundRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RemoveInbound, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Xray.App.Proxyman.Command.RemoveInboundResponse> RemoveInboundAsync(global::Xray.App.Proxyman.Command.RemoveInboundRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RemoveInboundAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Xray.App.Proxyman.Command.RemoveInboundResponse> RemoveInboundAsync(global::Xray.App.Proxyman.Command.RemoveInboundRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RemoveInbound, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Xray.App.Proxyman.Command.AlterInboundResponse AlterInbound(global::Xray.App.Proxyman.Command.AlterInboundRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AlterInbound(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Xray.App.Proxyman.Command.AlterInboundResponse AlterInbound(global::Xray.App.Proxyman.Command.AlterInboundRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AlterInbound, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Xray.App.Proxyman.Command.AlterInboundResponse> AlterInboundAsync(global::Xray.App.Proxyman.Command.AlterInboundRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AlterInboundAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Xray.App.Proxyman.Command.AlterInboundResponse> AlterInboundAsync(global::Xray.App.Proxyman.Command.AlterInboundRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AlterInbound, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Xray.App.Proxyman.Command.AddOutboundResponse AddOutbound(global::Xray.App.Proxyman.Command.AddOutboundRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddOutbound(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Xray.App.Proxyman.Command.AddOutboundResponse AddOutbound(global::Xray.App.Proxyman.Command.AddOutboundRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddOutbound, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Xray.App.Proxyman.Command.AddOutboundResponse> AddOutboundAsync(global::Xray.App.Proxyman.Command.AddOutboundRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddOutboundAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Xray.App.Proxyman.Command.AddOutboundResponse> AddOutboundAsync(global::Xray.App.Proxyman.Command.AddOutboundRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddOutbound, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Xray.App.Proxyman.Command.RemoveOutboundResponse RemoveOutbound(global::Xray.App.Proxyman.Command.RemoveOutboundRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RemoveOutbound(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Xray.App.Proxyman.Command.RemoveOutboundResponse RemoveOutbound(global::Xray.App.Proxyman.Command.RemoveOutboundRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RemoveOutbound, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Xray.App.Proxyman.Command.RemoveOutboundResponse> RemoveOutboundAsync(global::Xray.App.Proxyman.Command.RemoveOutboundRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RemoveOutboundAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Xray.App.Proxyman.Command.RemoveOutboundResponse> RemoveOutboundAsync(global::Xray.App.Proxyman.Command.RemoveOutboundRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RemoveOutbound, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Xray.App.Proxyman.Command.AlterOutboundResponse AlterOutbound(global::Xray.App.Proxyman.Command.AlterOutboundRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AlterOutbound(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Xray.App.Proxyman.Command.AlterOutboundResponse AlterOutbound(global::Xray.App.Proxyman.Command.AlterOutboundRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AlterOutbound, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Xray.App.Proxyman.Command.AlterOutboundResponse> AlterOutboundAsync(global::Xray.App.Proxyman.Command.AlterOutboundRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AlterOutboundAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Xray.App.Proxyman.Command.AlterOutboundResponse> AlterOutboundAsync(global::Xray.App.Proxyman.Command.AlterOutboundRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AlterOutbound, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override HandlerServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new HandlerServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(HandlerServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddInbound, serviceImpl.AddInbound)
          .AddMethod(__Method_RemoveInbound, serviceImpl.RemoveInbound)
          .AddMethod(__Method_AlterInbound, serviceImpl.AlterInbound)
          .AddMethod(__Method_AddOutbound, serviceImpl.AddOutbound)
          .AddMethod(__Method_RemoveOutbound, serviceImpl.RemoveOutbound)
          .AddMethod(__Method_AlterOutbound, serviceImpl.AlterOutbound).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, HandlerServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddInbound, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Xray.App.Proxyman.Command.AddInboundRequest, global::Xray.App.Proxyman.Command.AddInboundResponse>(serviceImpl.AddInbound));
      serviceBinder.AddMethod(__Method_RemoveInbound, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Xray.App.Proxyman.Command.RemoveInboundRequest, global::Xray.App.Proxyman.Command.RemoveInboundResponse>(serviceImpl.RemoveInbound));
      serviceBinder.AddMethod(__Method_AlterInbound, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Xray.App.Proxyman.Command.AlterInboundRequest, global::Xray.App.Proxyman.Command.AlterInboundResponse>(serviceImpl.AlterInbound));
      serviceBinder.AddMethod(__Method_AddOutbound, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Xray.App.Proxyman.Command.AddOutboundRequest, global::Xray.App.Proxyman.Command.AddOutboundResponse>(serviceImpl.AddOutbound));
      serviceBinder.AddMethod(__Method_RemoveOutbound, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Xray.App.Proxyman.Command.RemoveOutboundRequest, global::Xray.App.Proxyman.Command.RemoveOutboundResponse>(serviceImpl.RemoveOutbound));
      serviceBinder.AddMethod(__Method_AlterOutbound, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Xray.App.Proxyman.Command.AlterOutboundRequest, global::Xray.App.Proxyman.Command.AlterOutboundResponse>(serviceImpl.AlterOutbound));
    }

  }
}
#endregion
