using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BlackClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start the client
            StartClient();
        }

        static void StartClient()
        {
            try
            {
                // Set up the TcpClient
                Int32 port = 13000;
                var client = new TcpClient("127.0.0.1", port);

                // Translate the passed message into ASCII and store it as a Byte array.
                NetworkStream stream = client.GetStream();
                
                // Loop to send and receive data
                while (true)
                {
                    Console.Write("Enter a message (type 'q' to quit): ");
                    string message = Console.ReadLine();

                    // Convert message to byte array and send
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    stream.Write(data, 0, data.Length);

                    // Check if the user wants to quit
                    if (message.ToLower().Trim() == "q")
                    {
                        break;
                    }

                    // Receive response from the server
                    data = new byte[256];
                    int bytes = stream.Read(data, 0, data.Length);
                    string responseData = Encoding.ASCII.GetString(data, 0, bytes);
                    var par=new Parser();
                    var parsedCard = par.ParseCard(responseData);
                    //Console.WriteLine("Received: {0}", responseData);
                    foreach (var card in parsedCard)
                    {
                        card.Description();
                    }
                }

                // Close everything
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }

            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
        }

        
    }
}