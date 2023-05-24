using Microsoft.AspNetCore.SignalR;

namespace my_real_time_comments_app.CommentsHub
{
    /// <summary>
    /// A hub for sending messages to clients
    /// </summary>
    public class CommentsHub : Hub
    {
        public async Task SendComment(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveComment", user, message);
        }
    }
}
