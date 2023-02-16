// See https://aka.ms/new-console-template for more information



using Grpc.Net.Client;
using MyProject.GrpcClient;

Console.WriteLine("Hello, World!");

using var channel = GrpcChannel.ForAddress("https://localhost:7042");
var client = new Authorization.AuthorizationClient(channel);
var reply = await client.CheckAccessAsync(
                  new AuthorizationRequest { UserId = 1, Hmo = "view_all_data" }) ;
Console.WriteLine("Allow: " + reply.Allow);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();

