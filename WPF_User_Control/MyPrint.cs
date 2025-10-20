using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_User_Control
{
    public class MyPrint : IPrintable
    {
        public void Print(string text)
        {
            throw new NotImplementedException();
        }

        public void Print(string format, string text)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public bool TryToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
