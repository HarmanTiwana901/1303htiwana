using System;
using System.Net;

class Assignment2
{

    public bool validateIPAddress(string ip)
    {
        IPAddress ipParsed;
        bool ValidateIP = IPAddress.TryParse(ip, out ipParsed);
        if (ValidateIP)
        {
            Console.WriteLine("Valid ip address");
            return true;
        } else
        {
            Console.WriteLine("Invalid ip address");
            return false;
        }
           
       
            
        
    }

}

class Program
{
    static void Main()
    {
        Assignment2 validate = new Assignment2();
        //Console.WriteLine(validate.ValidateIPAddress("192.168.56.1"));

        //var ipParts = new Byte[] { 101, 102, 103, 0 };
        var checker = validate.validateIPAddress("192.168.56.1");

        Console.WriteLine("IP Address:{0}", checker);
       
    }
}