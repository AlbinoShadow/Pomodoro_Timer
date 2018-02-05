using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DFS_Exercise
{
    public partial class StatusConnections : Form
    {
        private Dictionary<string, Dictionary<string, bool>> connectedClientList;

        public StatusConnections()
        {
            InitializeComponent();
            connectionTimer.Enabled = true;
        }

        public StatusConnections(UDPNet.UDPNet UdpInject) : this()
        {
            connectedClientList = UdpInject.getConnectionList();
        }

        // connectionTimer ticks every 100ms.
        private void connectionTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("test");
            Console.WriteLine(connectedClientList.ToString());
        }
    }
}
