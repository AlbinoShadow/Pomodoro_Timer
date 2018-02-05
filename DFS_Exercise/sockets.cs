using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Collections.Generic;

namespace UDPNet
{
    public class UDPNet
    {
        // 6112 shares services with some of Blizzard's applications.
        const int PORT = 6112;
        Thread t = null;
        private readonly UdpClient udpClient = new UdpClient(PORT);
        private string hostname;
        private bool status;
        private string incomingIp;
        private Boolean receivedBool = false;
        private Dictionary<string, Dictionary<string, bool>> _ipHostStatusList = new Dictionary<string, Dictionary<string, bool>>();
        private Dictionary<string, bool> _nestedDict = new Dictionary<string, bool>();
        IAsyncResult async_ = null;

        private void startReceiving()
        {
            async_ = udpClient.BeginReceive(receive, new object());
        }

        private void receive(IAsyncResult async)
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, PORT);
            byte[] bytes = udpClient.EndReceive(async, ref ip);
            string msg = Encoding.ASCII.GetString(bytes);
            Console.WriteLine("{0} says: {1}", ip.Address.ToString(), msg);
            incomingIp = ip.Address.ToString();

            if (Boolean.TryParse(msg, out receivedBool))
                status = receivedBool;
            else
                hostname = msg;

            // If the nested dictionary contains the hostname already, update the status, otherwise add it.
            if (_nestedDict.ContainsKey(hostname))
                _nestedDict[hostname] = status;
            else
                _nestedDict.Add(hostname, status);

            // If the main dictionary contains data from that IP already, update the nested dictionary, otherwise add it.
            if (_ipHostStatusList.ContainsKey(incomingIp))
                _ipHostStatusList[incomingIp] = _nestedDict;
            else
                _ipHostStatusList.Add(incomingIp, _nestedDict);

            startReceiving();
        }

        public Dictionary<string, Dictionary<string, bool>> getConnectionList()
        {
            return _ipHostStatusList;
        }

        public Dictionary<string, bool> getNestedList()
        {
            return _nestedDict;
        }

        public void start()
        {
            if (t != null)
            {
                throw new Exception("Already receiving, please stop before starting again.");
            }
            Console.WriteLine("Started UDP receiving on port " + PORT);
            startReceiving();
        }

        public void stop()
        {
            try
            {
                udpClient.Close();
            }
            catch
            {
                Console.WriteLine("Stopped UDP receiving");
            }
        }

        public void send(bool status, string hostname)
        {
            UdpClient receiving = new UdpClient();
            IPEndPoint ip = new IPEndPoint(IPAddress.Broadcast, PORT);  // IPAddress.Broadcast is 255.255.255.255
            byte[] bytes = Encoding.ASCII.GetBytes(hostname);
            receiving.Send(bytes, bytes.Length, ip);
            bytes = Encoding.ASCII.GetBytes(status.ToString());
            receiving.Send(bytes, bytes.Length, ip);
            receiving.Close();
        }
    }
}