using System;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Botonera_Relays
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
            //Socket A = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //A.Connect("192.168.0.100", 8080);
            //A.Send(new byte[] { 0, 1, 2, 3, 4 });
            //A.Close();

        }
    }
}
