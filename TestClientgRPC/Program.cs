using Grpc.Net.Client;
using TestClientgRPC;

class Program
{
    static async Task Main(string[] args)
    {
        using var channel = GrpcChannel.ForAddress("http://localhost:8080");
        var client = new HelloService.HelloServiceClient(channel);
        var reply = await client.helloAsync(
            new HelloRequest { FirstName = "Plamen", LastName = " Michev" }
        );
        Console.WriteLine("Greeting: " + reply.Greeting);
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        Console.WriteLine("Hello World!");
    }
}
