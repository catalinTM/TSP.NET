using System;
using System.Net.Http;
using System.Threading.Tasks;
using GrpcGreeter;
using Grpc.Net.Client;


namespace GrpcGreeterClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);


            static async Task AddComment(GrpcChannel channel, Comment c)
            {

                var reply = await client.AddComment(c);
                Console.WriteLine(reply.Result);
            }

            Console.ReadKey();
        }
    }
}
