using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BuetoothToArduinoTest
{
    public interface IBth
    {
        void Send(string message);
        void Disconnect();
        void Connect(string name);
        List<string> PairedDevices();
    }
}

