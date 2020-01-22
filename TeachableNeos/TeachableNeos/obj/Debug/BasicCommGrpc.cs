// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: basic_comm.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

public static partial class DataComm
{
  static readonly string __ServiceName = "DataComm";

  static readonly grpc::Marshaller<global::Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Empty.Parser.ParseFrom);
  static readonly grpc::Marshaller<global::Feature> __Marshaller_Feature = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Feature.Parser.ParseFrom);

  static readonly grpc::Method<global::Empty, global::Feature> __Method_GetFeatures = new grpc::Method<global::Empty, global::Feature>(
      grpc::MethodType.Unary,
      __ServiceName,
      "GetFeatures",
      __Marshaller_Empty,
      __Marshaller_Feature);

  /// <summary>Service descriptor</summary>
  public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
  {
    get { return global::BasicCommReflection.Descriptor.Services[0]; }
  }

  /// <summary>Base class for server-side implementations of DataComm</summary>
  [grpc::BindServiceMethod(typeof(DataComm), "BindService")]
  public abstract partial class DataCommBase
  {
    /// <summary>
    /// (Method definitions not shown)
    /// </summary>
    /// <param name="request">The request received from the client.</param>
    /// <param name="context">The context of the server-side call handler being invoked.</param>
    /// <returns>The response to send back to the client (wrapped by a task).</returns>
    public virtual global::System.Threading.Tasks.Task<global::Feature> GetFeatures(global::Empty request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

  }

  /// <summary>Client for DataComm</summary>
  public partial class DataCommClient : grpc::ClientBase<DataCommClient>
  {
    /// <summary>Creates a new client for DataComm</summary>
    /// <param name="channel">The channel to use to make remote calls.</param>
    public DataCommClient(grpc::ChannelBase channel) : base(channel)
    {
    }
    /// <summary>Creates a new client for DataComm that uses a custom <c>CallInvoker</c>.</summary>
    /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
    public DataCommClient(grpc::CallInvoker callInvoker) : base(callInvoker)
    {
    }
    /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
    protected DataCommClient() : base()
    {
    }
    /// <summary>Protected constructor to allow creation of configured clients.</summary>
    /// <param name="configuration">The client configuration.</param>
    protected DataCommClient(ClientBaseConfiguration configuration) : base(configuration)
    {
    }

    /// <summary>
    /// (Method definitions not shown)
    /// </summary>
    /// <param name="request">The request to send to the server.</param>
    /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
    /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
    /// <param name="cancellationToken">An optional token for canceling the call.</param>
    /// <returns>The response received from the server.</returns>
    public virtual global::Feature GetFeatures(global::Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return GetFeatures(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    /// <summary>
    /// (Method definitions not shown)
    /// </summary>
    /// <param name="request">The request to send to the server.</param>
    /// <param name="options">The options for the call.</param>
    /// <returns>The response received from the server.</returns>
    public virtual global::Feature GetFeatures(global::Empty request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_GetFeatures, null, options, request);
    }
    /// <summary>
    /// (Method definitions not shown)
    /// </summary>
    /// <param name="request">The request to send to the server.</param>
    /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
    /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
    /// <param name="cancellationToken">An optional token for canceling the call.</param>
    /// <returns>The call object.</returns>
    public virtual grpc::AsyncUnaryCall<global::Feature> GetFeaturesAsync(global::Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return GetFeaturesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    /// <summary>
    /// (Method definitions not shown)
    /// </summary>
    /// <param name="request">The request to send to the server.</param>
    /// <param name="options">The options for the call.</param>
    /// <returns>The call object.</returns>
    public virtual grpc::AsyncUnaryCall<global::Feature> GetFeaturesAsync(global::Empty request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_GetFeatures, null, options, request);
    }
    /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
    protected override DataCommClient NewInstance(ClientBaseConfiguration configuration)
    {
      return new DataCommClient(configuration);
    }
  }

  /// <summary>Creates service definition that can be registered with a server</summary>
  /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
  public static grpc::ServerServiceDefinition BindService(DataCommBase serviceImpl)
  {
    return grpc::ServerServiceDefinition.CreateBuilder()
        .AddMethod(__Method_GetFeatures, serviceImpl.GetFeatures).Build();
  }

  /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
  /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
  /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
  /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
  public static void BindService(grpc::ServiceBinderBase serviceBinder, DataCommBase serviceImpl)
  {
    serviceBinder.AddMethod(__Method_GetFeatures, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Empty, global::Feature>(serviceImpl.GetFeatures));
  }

}
#endregion
