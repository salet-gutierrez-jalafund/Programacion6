// Clase de prueba del patrón Mediator
class Program
{
    static void Main(string[] args)
    {
        // Crear el mediador (ChatRoom)
        IChatRoomMediator chatRoom = new ChatRoom();

        // Crear los usuarios (Colleagues)
        User user1 = new User("Alice", chatRoom);
        User user2 = new User("Bob", chatRoom);

        // Los usuarios envían mensajes a través del mediador
        user1.SendMessage("Hola Bob!");
        user2.SendMessage("Hola Alice, ¿cómo estás?");
    }
}