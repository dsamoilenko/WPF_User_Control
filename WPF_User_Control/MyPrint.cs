using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

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

        void IPrintable.Print(List<string> strings)
        {
            throw new NotImplementedException();
        }

        void IPrintable.Print(Image image)
        {
            throw new NotImplementedException();
        }
    }
}
