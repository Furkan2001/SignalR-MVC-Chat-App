namespace SignalRMVCApp.SignalRHub;

public interface INotificationClient
{
    // It has method that should be listen by client
    Task NewUserJoined(string userName);
    Task ReceiveMessage(string fromUser, string message);
    Task GetConnectedUsers(List<string> users);
}
