using Reader;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class MySerialPort
    {
        public SerialPort _Port;
        Form1 myForm;
        //RichTextBox myRb;
        DataGridView myRb;
        RichTextBox myTb;
        public MySerialPort(SerialPort p, Form1 f,DataGridView rb,RichTextBox tb, String PortName)
        {
            this._Port = p;
            this.myForm = f;
            this.myRb = rb;
            this.myTb = tb;

            ConnectPorts(p, PortName);

        }

        public void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Task.Run(() => DataRecives(_Port.ReadExisting()));
        }

        public void DataRecives(string info)//veri geldiğinde listeye ekleyen f
        {
            Thread.Sleep(30);
            GlobalVariables.barcodeReaderManager.addNewData(info + "\r\n");
            //Task.Run(() => UIOperation(myRb, info));
        }

        #region overload
        //public async void UIOperation(RichTextBox _rb, string textSN)
        //{

        //    await Task.Run(() =>
        //    {
        //        //dataPack.Add(textSN + " - " + _Port.PortName);
        //        //myForm.Invoke(new Action(() => SetRichEditText(_rb, textSN + " - " + _Port.PortName + "\r\n")));
        //    });
        //}
        #endregion
        public static void SetRichEditText(RichTextBox obj, string text)
        {
            obj.AppendText(text);
            obj.ScrollToCaret();
        }

        public async void UIOperation(RichTextBox _tb, string text)
        {

            await Task.Run(() =>
            {
                myForm.Invoke(new Action(() => _tb.Text += _Port.PortName + text + "\n"));

            });
        }

        public void ConnectPorts(SerialPort serialPort, string portName)
        {
            if (!serialPort.IsOpen)
            {
                serialPort.PortName = portName;
                serialPort.BaudRate = 9600;
                serialPort.Open();
                UIOperation(myTb, " - Connected \r\n");
            }
            //else
            //    UIOperation(myTb, "Already Connected");


        }
    }
}
