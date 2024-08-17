using AdapterUSBToNetwork.Adapters;
using AdapterUSBToNetwork.Client;
using AdapterUSBToNetwork.Interfaces;
using AdapterUSBToNetwork.LegacyCode;


/// <summary>
/// Definicion:
/// El patrón Adapter es un patrón de diseño
/// estructural que permite que dos interfaces incompatibles
/// colaboren. En lugar de modificar las interfaces existentes
/// 
/// Cuando se Usa:
/// - Tienes clases con interfaces incompatibles
/// - Necesitas reutilizar una clase existente
/// - Quieres mantener la compatibilidad con versiones anteriores
/// </summary>
// Uso del adaptadorc
public class Program
{
    public static void Main()
    {
        // Crear una instancia del dispositivo USB
        USBDevice usbDevice = new USBDevice();
        
        // Crear el adaptador que convierte el dispositivo USB en un dispositivo de red
        INetworkDevice adapter = new USBToNetworkAdapter(usbDevice);
        
        // Crear el cliente que usa dispositivos de red
        NetworkClient client = new NetworkClient(adapter);
        
        // Usar el cliente para conectar el dispositivo USB a la red
        client.ConnectDevice("192.168.1.1");
    }
}