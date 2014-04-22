using System;
using System.Web;
using Microsoft.AspNet.SignalR;
using MVChat.Model;

namespace MVChat.ViewController.Hubs
{
    public class MessageHub : Hub
    {
        public void SendMessage(Message message)
        {
            message.Date = DateTime.Now;
            Clients.All.showMessage(message);
        }
    }
}