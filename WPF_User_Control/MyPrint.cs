using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WPF_User_Control
{
    public class MyPrint : IPrintable
    {
        public void Print(string text)
        {}

        public void Print(string format, string text)
        {}

        void IPrintable.Print(BitmapImage image, BitmapDecoder decoder)
        {}

        bool IPrintable.TryToPrint(string text)
        {
            return false;
        }
    }
}
