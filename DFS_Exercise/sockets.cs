using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

namespace UDPNet
{
    class UDPNet
    {
        // I chose 6112 because it was already an open port.
        // It shares services with some of Blizzard's applications.
        const int PORT = 6112;
        Thread t = null;
        private readonly UdpClient udpClient = new UdpClient(PORT);
        IAsyncResult async_ = null;

        private void startListening()
        {
            async_ = udpClient.BeginReceive(Receive, new object());
        }

        private void Receive(IAsyncResult async)
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, PORT);
            byte[] bytes = udpClient.EndReceive(async, ref ip);
            string msg = Encoding.ASCII.GetString(bytes);
            Console.WriteLine("Received {0}'s status!", ip.Address.ToString());
            startListening();
        }

        public void start()
        {
            if (t != null)
            {
                throw new Exception("Already listening, please stop before starting again.");
            }
            Console.WriteLine("Started UDP listening on port " + PORT);
            startListening();
        }

        public void stop()
        {
            try
            {
                udpClient.Close();
            }
            catch
            {
                Console.WriteLine("Stopped UDP listening");
            }
        }

        public void send(bool status)
        {
            UdpClient receiving = new UdpClient();
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("255.255.255.255"), PORT);
            byte[] bytes = BitConverter.GetBytes(status);
            receiving.Send(bytes, bytes.Length, ip);
            receiving.Close();
            Console.WriteLine("Sent: {0} ", status);
        }
    }
}