using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace EviCRM.TerminalWebServer.Hubs
{
    public class StatusHub : Hub
    {
        //---------------------------------------------------------------------
        //                          SignalR StatusHub
        //---------------------------------------------------------------------

        public async Task SendAll(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            await Clients.All.SendAsync("broadcastMessage", name, message);
        }
        public async Task SendAllExceptMe(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            await Clients.Others.SendAsync("broadcastMessage", name, message);
        }
        public async Task SendBack(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            await Clients.Caller.SendAsync("broadcastMessage", name, message);
        }
    }

    public class MainHub : Hub
    {
        //---------------------------------------------------------------------
        //                          SignalR MainHub
        //---------------------------------------------------------------------

        public async Task SendAll(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            await Clients.All.SendAsync("broadcastMessage", name, message);
        }
        public async Task SendAllExceptMe(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            await Clients.Others.SendAsync("broadcastMessage", name, message);
        }
        public async Task SendBack(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            await Clients.Caller.SendAsync("broadcastMessage", name, message);
        }
    }
    public class DataHub : Hub
    {
        //---------------------------------------------------------------------
        //                          SignalR DataHub
        //---------------------------------------------------------------------

        public async Task SendAll(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            await Clients.All.SendAsync("broadcastMessage", name, message);
        }
        public async Task SendAllExceptMe(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            await Clients.Others.SendAsync("broadcastMessage", name, message);
        }
        public async Task SendBack(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            await Clients.Caller.SendAsync("broadcastMessage", name, message);
        }
    }
    public class CmdsHub: Hub
    {
        //---------------------------------------------------------------------
        //                          SignalR CmdsHub
        //---------------------------------------------------------------------

        public async Task SendAll(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            await Clients.All.SendAsync("broadcastMessage", name, message);
        }
        public async Task SendAllExceptMe(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            await Clients.Others.SendAsync("broadcastMessage", name, message);
        }
        public async Task SendBack(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            await Clients.Caller.SendAsync("broadcastMessage", name, message);
        }
    }
    public class GeneralHub : Hub
    {
        //---------------------------------------------------------------------
        //                          SignalR General Operator
        //---------------------------------------------------------------------

        public async Task SendAll(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            await Clients.All.SendAsync("broadcastMessage", name, message);
        }
        public async Task SendAllExceptMe(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            await Clients.Others.SendAsync("broadcastMessage", name, message);
        }
        public async Task SendBack(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            await Clients.Caller.SendAsync("broadcastMessage", name, message);
        }

        
    }
}
