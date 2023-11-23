using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Manager
{
    public class BarcodeReaderManager
    {
        private List<string> BarcodeInfo { get; set; }

        private object _lock = new object();

        public BarcodeReaderManager() { BarcodeInfo = new List<string>(); }


        public bool addNewData(string readedData)
        {
            lock (_lock)
            {
                try
                {
                    BarcodeInfo.Add(readedData);
                    return true;
                }
                catch { return false; }
            }

        }

        public List<string> getAllData()
        {
            lock (_lock)
            {
                return BarcodeInfo.ToList();
            }
        }

        public bool InitializeList()
        {
            lock (_lock)
            {
                try
                {
                    BarcodeInfo=new List<string>();
                    return true;
                }
                catch { return false; }
            }

        }


    }
}
