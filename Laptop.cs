using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentonElectronicdevices
{
    public class Laptop : IConnectable, IRechargeable, IDisplayable
    {
        bool con;
        public Laptop(bool con)
        {
            this.con = con;
        }
        public int Charge(int minutes)
        {
            return minutes;
        }

        public bool Connect()
        {
            if (con == true)
            {
                return true;
            }
            return false;
        }

        public string Display()
        {
            string info = "Desktop Resolution :1920*1080\nRefresh Rate :80Hz\nBit Depth :8-bit\nColor Format :RGB\nColor Space :SDR";
            return info;
        }
    }
}
