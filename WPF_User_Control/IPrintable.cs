using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WPF_User_Control
{
    public interface IPrintable
    {
        void Print(string text);
        void Print(string text, string format);
        void Print(BitmapImage image, BitmapDecoder decoder);
        bool TryToPrint(string text);
    }
}
