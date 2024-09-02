using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.Ua;
using OpcUaHelper;
namespace MonitorNC
{
    internal class OpcTool
    {
        OpcUaClient m_OpcUaClient = new OpcUaClient();
        
        
        public async void getConnectted()
        {
            m_OpcUaClient.UserIdentity = new UserIdentity("OpcUaClient", "OpcUaClient");
            try
            {
                await m_OpcUaClient.ConnectServer("opc.tcp://192.168.227.15:4840");
                
                //UserControl1.setConnectStatusLabelText("连接成功");
            }
            catch (Exception e)
            {
                //UserControl1.setConnectStatusLabelText(e.Message);
                throw;
            }
        }
    }
}
