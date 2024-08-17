using System;

namespace AdapterUSBToNetwork.Interfaces;

// La interfaz moderna que la aplicación espera para dispositivos de red
public interface INetworkDevice
{
    void ConnectToNetwork(string ipAddress);
}
