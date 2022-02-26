using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Threading.Tasks;

namespace SignalR_1_client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var connection = new HubConnectionBuilder().WithAutomaticReconnect().WithUrl("http://localhost:55681/chatHub").Build();
            await connection.StartAsync();
        }
    }
}
