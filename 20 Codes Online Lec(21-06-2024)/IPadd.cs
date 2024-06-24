using System;
using System.Net;
using System.Net.Sockets;

class Program
{
    static void Main()
    {
        
        string hostName = Dns.GetHostName();
        Console.WriteLine("Host Name: " + hostName);

        IPAddress[] addresses = Dns.GetHostAddresses(hostName);
        foreach (IPAddress address in addresses)
        {
            Console.WriteLine("IP Address: " + address.ToString());
        }
    }
}