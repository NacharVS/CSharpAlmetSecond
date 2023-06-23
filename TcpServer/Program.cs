using System.Net;
using System.Net.Sockets;
using System.Text;

var tcpListener = new TcpListener(IPAddress.Any, 8888);
var words = new Dictionary<string, string>()
{
    {"red", "красный" },
    {"blue", "синий" },
    {"green", "зеленый" }
};
try
{
    tcpListener.Start();   
    Console.WriteLine("Server is Started. Waiting for connections... ");

    while (true)
    {
        using var tcpClient = await tcpListener.AcceptTcpClientAsync();
        var stream = tcpClient.GetStream();
        var response = new List<byte>();
        int bytesRead = 10;
        while (true)
        {
            while ((bytesRead = stream.ReadByte()) != '\n')
            {
                response.Add((byte)bytesRead);
            }
            var word = Encoding.UTF8.GetString(response.ToArray());
            if (word == "END") break;

            Console.WriteLine($"Request for translation {word}");
            if (!words.TryGetValue(word, out var translation)) translation = "No data";
            translation += '\n';
            await stream.WriteAsync(Encoding.UTF8.GetBytes(translation));
            response.Clear();
        }
    }
}
finally
{
    tcpListener.Stop();
}