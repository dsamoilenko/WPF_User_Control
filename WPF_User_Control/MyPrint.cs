using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Controls;

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
        void IPrintable.Print(List<string> strings)
        {
            throw new NotImplementedException();
        }

        bool IPrintable.TryToPrint(string text)
        {
            return false;
        }

        void Print(Image image)
        {
            
        }

        void IPrintable.TryToPrint(Image image)
        {
            throw new NotImplementedException();
        }
    }
}
