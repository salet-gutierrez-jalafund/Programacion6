using System;
using AdapterUSBToNetwork.Interfaces;

namespace AdapterUSBToNetwork.Client;

// Cliente que usa dispositivos de red
public class NetworkClient
{
    private readonly INetworkDevice _networkDevice;

    // Constructor que recibe un dispositivo de red
    public NetworkClient(INetworkDevice networkDevice)
    {
        _networkDevice = networkDevice;
    }

    // Método que usa el dispositivo de red
    public void ConnectDevice(string ipAddress)
    {
        _networkDevice.ConnectToNetwork(ipAddress);
    }
}