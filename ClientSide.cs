using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    class ClientSide
    {
        private TcpClient client;
        private TcpListener listener;
        private StreamReader reader;

        public bool IsConnect
        {
            get;
            set;
        } = false;

        public bool ShouldStop
        {
            get;
            set;
        } = false;


        public void StartConnect(string ip, int port)
        {
            if (listener != null)
            {
                EndConnect();
            }

            listener = new TcpListener(new IPEndPoint(IPAddress.Parse(ip), port));
            listener.Start();
        }

        public void EndConnect()
        {
            IsConnect = false;
            listener.Stop();
            client.Close();
        }

        public string[] GetInput()
        {
            string commandInput = "";
            string[] input;
            
            if (!IsConnect)
            {
                IsConnect = true;
                reader = new StreamReader(client.GetStream());
                client = listener.AcceptTcpClient();
            }

            commandInput = reader.ReadLine();
            input = commandInput.Split(',');
            string[] result = { input[0], input[1] };

            return result;

        }
            
       /*     client.Connect(ep);
            Console.WriteLine("You are connectedddddd");

            using (NetworkStream stream = client.GetStream())
            using (StreamReader reader = new StreamReader(stream))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                // Send data to server
                // Console.Write("Please enter a number: ");
                //int num = int.Parse(Console.ReadLine());
                //writer.Write(num);
                // Get result from server
                string result = "set controls/flight/rudder 1";
                result = result + "\n";
                Console.WriteLine(result);
                writer.WriteLine(result);
            }
            client.Close();
        }*/
    }
}
