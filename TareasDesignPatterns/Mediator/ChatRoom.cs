// Clase concreta del mediador que gestiona el chat
class ChatRoom : IChatRoomMediator
{
    public void ShowMessage(User user, string message)
    {
        string time = DateTime.Now.ToString("hh:mm");
        string sender = user.GetName();
        Console.WriteLine($"{time} [{sender}]: {message}");
    }
}