using AdapterUSBToNetwork.Interfaces;
using AdapterUSBToNetwork.LegacyCode;

namespace AdapterUSBToNetwork.Adapters;

// El adaptador que permite conectar un dispositivo USB a la red
public class USBToNetworkAdapter : INetworkDevice
{
    private readonly USBDevice _usbDevice;

    // Constructor que recibe un dispositivo USB
    public USBToNetworkAdapter(USBDevice usbDevice)
    {
        _usbDevice = usbDevice;
    }

    // Implementación del método ConnectToNetwork para adaptarse a la interfaz de red
    public void ConnectToNetwork(string ipAddress)
    {
        // Conectar el dispositivo USB como si estuviera en la red
        Console.WriteLine($"Connecting USB device to network at IP address: {ipAddress}");
        
        // Usar el método del dispositivo USB para conectarlo
        _usbDevice.ConnectToUSBPort();
        
        // Simulación de convertir la conexión USB a una conexión de red
        Console.WriteLine("USB device is now available as a network device.");
    }
}