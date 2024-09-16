class Program
{
    static void Main(string[] args)
    {
        // Crear los manejadores
        var rep = new CustomerServiceRep();
        var supervisor = new Supervisor();
        var manager = new Manager();

        // Configurar la cadena de responsabilidad
        rep.SetNextHandler(supervisor);
        supervisor.SetNextHandler(manager);

        // Procesar varias quejas
        rep.HandleComplaint("Producto llegó dañado", 1);
        rep.HandleComplaint("No recibí mi pedido", 3);
        rep.HandleComplaint("Servicio muy lento y grosero", 5);
    }
}