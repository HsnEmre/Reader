using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Reader
{
    public partial class Form1 : Form
    {

        public bool workstation = true;
        List<MySerialPort> SerialPortList = new List<MySerialPort>();
        public Form1()
        {
            InitializeComponent();
        }


        //var lastReadedData = GlobalVariables.barcodeReaderManager.getAllData().Distinct().OrderBy(x => x).ToList();

        #region SerialPortveVerileriAl
        private void ReadSerial_DoWork(object sender, DoWorkEventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            while (workstation)
            {
                var tmpSerialPortLis = SerialPort.GetPortNames().Distinct().ToList();
                tmpSerialPortLis.ForEach(x =>
                {
                    try
                    {
                        SerialPort port = new SerialPort();
                        if (SerialPortList.Where(y => y._Port.PortName == x).ToList().Count() == 0)
                        {
                            MySerialPort _port = new MySerialPort(port, this, this.dtatcp, this.richLog, x);
                            port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(_port.SerialPortDataReceived);
                            SerialPortList.Add(_port);
                        }
                        else
                        {
                            var item = SerialPortList.Where(y => y._Port.PortName == x).FirstOrDefault();
                            item.ConnectPorts(item._Port, item._Port.PortName);
                        }

                    }
                    catch
                    {

                    }

                });

                Thread.Sleep(300);

            }
        }
        #endregion




    }
}
