using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF_User_Control
{
    public interface IPrintable
    {
        void Print(string text);
        void Print(string formatStr, string textToPrint);
        void Print(List<string> strings);
        void Print(Image image);
    }
}
