// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: airdrop/v4/airdrop_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Kin.Agora.Airdrop.V4 {
  /// <summary>
  /// Airdrop service sends Kin to accounts for free. It is only available on development networks.
  /// </summary>
  public static partial class Airdrop
  {
    static readonly string __ServiceName = "kin.agora.airdrop.v4.Airdrop";

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

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

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

    static readonly grpc::Marshaller<global::Kin.Agora.Airdrop.V4.RequestAirdropRequest> __Marshaller_kin_agora_airdrop_v4_RequestAirdropRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Kin.Agora.Airdrop.V4.RequestAirdropRequest.Parser));
    static readonly grpc::Marshaller<global::Kin.Agora.Airdrop.V4.RequestAirdropResponse> __Marshaller_kin_agora_airdrop_v4_RequestAirdropResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Kin.Agora.Airdrop.V4.RequestAirdropResponse.Parser));

    static readonly grpc::Method<global::Kin.Agora.Airdrop.V4.RequestAirdropRequest, global::Kin.Agora.Airdrop.V4.RequestAirdropResponse> __Method_RequestAirdrop = new grpc::Method<global::Kin.Agora.Airdrop.V4.RequestAirdropRequest, global::Kin.Agora.Airdrop.V4.RequestAirdropResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RequestAirdrop",
        __Marshaller_kin_agora_airdrop_v4_RequestAirdropRequest,
        __Marshaller_kin_agora_airdrop_v4_RequestAirdropResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Kin.Agora.Airdrop.V4.AirdropServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Airdrop</summary>
    [grpc::BindServiceMethod(typeof(Airdrop), "BindService")]
    public abstract partial class AirdropBase
    {
      /// <summary>
      /// RequestAirdrop requests an air drop of kin to the target account.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Kin.Agora.Airdrop.V4.RequestAirdropResponse> RequestAirdrop(global::Kin.Agora.Airdrop.V4.RequestAirdropRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Airdrop</summary>
    public partial class AirdropClient : grpc::ClientBase<AirdropClient>
    {
      /// <summary>Creates a new client for Airdrop</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AirdropClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Airdrop that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AirdropClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AirdropClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AirdropClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// RequestAirdrop requests an air drop of kin to the target account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Kin.Agora.Airdrop.V4.RequestAirdropResponse RequestAirdrop(global::Kin.Agora.Airdrop.V4.RequestAirdropRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RequestAirdrop(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// RequestAirdrop requests an air drop of kin to the target account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Kin.Agora.Airdrop.V4.RequestAirdropResponse RequestAirdrop(global::Kin.Agora.Airdrop.V4.RequestAirdropRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RequestAirdrop, null, options, request);
      }
      /// <summary>
      /// RequestAirdrop requests an air drop of kin to the target account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Kin.Agora.Airdrop.V4.RequestAirdropResponse> RequestAirdropAsync(global::Kin.Agora.Airdrop.V4.RequestAirdropRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RequestAirdropAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// RequestAirdrop requests an air drop of kin to the target account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Kin.Agora.Airdrop.V4.RequestAirdropResponse> RequestAirdropAsync(global::Kin.Agora.Airdrop.V4.RequestAirdropRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RequestAirdrop, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AirdropClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AirdropClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AirdropBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RequestAirdrop, serviceImpl.RequestAirdrop).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AirdropBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_RequestAirdrop, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Kin.Agora.Airdrop.V4.RequestAirdropRequest, global::Kin.Agora.Airdrop.V4.RequestAirdropResponse>(serviceImpl.RequestAirdrop));
    }

  }
}
#endregion
