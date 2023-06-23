
using System.Net;
using System.Net.Sockets;
using System.Text;


using TcpClient tcpClient = new TcpClient();
await tcpClient.ConnectAsync("127.0.0.1", 8888);

var words = new string[] { "red", "blue", "green" };
var stream = tcpClient.GetStream();
var response = new List<byte>();
int bytesRead = 10; 
foreach (var word in words)
{
    byte[] data = Encoding.UTF8.GetBytes(word + '\n');
    await stream.WriteAsync(data);
    while ((bytesRead = stream.ReadByte()) != '\n')
    {
        response.Add((byte)bytesRead);
    }
    var translation = Encoding.UTF8.GetString(response.ToArray());
    Console.WriteLine($"Word {word}: {translation}");
    response.Clear();
}


await stream.WriteAsync(Encoding.UTF8.GetBytes("END\n"));
Console.WriteLine("All messages sended");
