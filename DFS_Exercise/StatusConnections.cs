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

        // connectionTimer ticks every 2000ms.
        private void connectionTimer_Tick(object sender, EventArgs e)
        {
            connectionList.Rows.Clear();
            foreach (var item in connectedClientList)
            {
                string[] row = new string[] { "null", "null", "null" };

                row[0] = item.Key;

                foreach (var subItem in item.Value)
                {
                    row[1] = subItem.Key;
                    row[2] = subItem.Value.ToString();
                }

                connectionList.Rows.Add(row);
            }
        }
    }
}
