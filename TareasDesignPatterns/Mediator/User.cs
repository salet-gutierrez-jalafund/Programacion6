// Clase Colleague que representa a un usuario del chat
class User
{
    private string _name;
    private IChatRoomMediator _chatRoom;

    public User(string name, IChatRoomMediator chatRoom)
    {
        _name = name;
        _chatRoom = chatRoom;
    }

    public string GetName()
    {
        return _name;
    }

    public void SendMessage(string message)
    {
        _chatRoom.ShowMessage(this, message);
    }
}