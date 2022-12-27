using System;
using System.Net;

namespace WriteIP_V4
{
    class Program
    {
        
            
        static void Main(string[] args)
        {
            // solution 1
            //string input = "172.16.254.1";
            //Console.WriteLine(IsValidIP(input));
            //Console.ReadLine();

            // solution 2
            //Console.WriteLine("Enter IP Address: ");
            //string input = Console.ReadLine();
            //Console.WriteLine(IsValidIP(input));

            // solutin 3
            Console.Write("Please input : ");
            string userInput;
            userInput = Console.ReadLine();
            
            string ipAddress = "";
            while (userInput != "stop")
            {
                int value;
                string IP = (userInput);
                if(int.TryParse(IP, out value))
                {
                    if(int.Parse(IP) >= 0 && int.Parse(IP) <= 255)
                    {
                        ipAddress += IP;
                    }
                    else
                    {
                        Console.WriteLine(IsValidIP(ipAddress));
                        break;
                    }
                }
                else
                {
                    ipAddress += IP;
                }
                
                Console.WriteLine();
                userInput = Console.ReadLine();
            }
            if (userInput == "stop")
            {
                Console.WriteLine(IsValidIP(ipAddress));
            }

        }

        public static bool IsValidIP(string userInput)
        {
            IPAddress ipAddress;
            return IPAddress.TryParse(userInput, out ipAddress) && ipAddress.ToString() == userInput;
        }

    }
}
