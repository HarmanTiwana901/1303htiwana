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

   /*
    public bool ValidateIPAddress(String strIP)
    {

        try
        {
            char chrSeperate = '.'; // split
            string[] arrLens = strIP.Split(chrSeperate);


            if (arrLens.Length != 4)
            {
                return false;
            }

            Int32 temp;
            Int16 MAXVALUE = 255; // const for max length, makes sure user doesnt input a string thats too long

            foreach (String strLen in arrLens)
            {
                if (strLen.Length > 3)
                {
                    return false;
                }

                temp = int.Parse(strLen);
                if (temp > MAXVALUE)
                {
                    return false;
                }
            }
            return true;
        } catch(FormatException e)
        {
            Console.Write("Error");
            return false;
        }
       
    }
   */
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