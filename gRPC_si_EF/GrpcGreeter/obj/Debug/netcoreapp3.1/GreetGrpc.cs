// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greet.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcGreeter {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class Greeter
  {
    static readonly string __ServiceName = "greet.Greeter";

    static readonly grpc::Marshaller<global::GrpcGreeter.HelloRequest> __Marshaller_greet_HelloRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcGreeter.HelloRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcGreeter.HelloReply> __Marshaller_greet_HelloReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcGreeter.HelloReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcGreeter.CommentModel> __Marshaller_greet_CommentModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcGreeter.CommentModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcGreeter.Reply> __Marshaller_greet_Reply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcGreeter.Reply.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcGreeter.HelloRequest, global::GrpcGreeter.HelloReply> __Method_SayHello = new grpc::Method<global::GrpcGreeter.HelloRequest, global::GrpcGreeter.HelloReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayHello",
        __Marshaller_greet_HelloRequest,
        __Marshaller_greet_HelloReply);

    static readonly grpc::Method<global::GrpcGreeter.CommentModel, global::GrpcGreeter.Reply> __Method_AddComment = new grpc::Method<global::GrpcGreeter.CommentModel, global::GrpcGreeter.Reply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddComment",
        __Marshaller_greet_CommentModel,
        __Marshaller_greet_Reply);

    static readonly grpc::Method<global::GrpcGreeter.CommentModel, global::GrpcGreeter.Reply> __Method_UpdateComment = new grpc::Method<global::GrpcGreeter.CommentModel, global::GrpcGreeter.Reply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateComment",
        __Marshaller_greet_CommentModel,
        __Marshaller_greet_Reply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcGreeter.GreetReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Greeter</summary>
    [grpc::BindServiceMethod(typeof(Greeter), "BindService")]
    public abstract partial class GreeterBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcGreeter.HelloReply> SayHello(global::GrpcGreeter.HelloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcGreeter.Reply> AddComment(global::GrpcGreeter.CommentModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcGreeter.Reply> UpdateComment(global::GrpcGreeter.CommentModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GreeterBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SayHello, serviceImpl.SayHello)
          .AddMethod(__Method_AddComment, serviceImpl.AddComment)
          .AddMethod(__Method_UpdateComment, serviceImpl.UpdateComment).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GreeterBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SayHello, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcGreeter.HelloRequest, global::GrpcGreeter.HelloReply>(serviceImpl.SayHello));
      serviceBinder.AddMethod(__Method_AddComment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcGreeter.CommentModel, global::GrpcGreeter.Reply>(serviceImpl.AddComment));
      serviceBinder.AddMethod(__Method_UpdateComment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcGreeter.CommentModel, global::GrpcGreeter.Reply>(serviceImpl.UpdateComment));
    }

  }
}
#endregion
