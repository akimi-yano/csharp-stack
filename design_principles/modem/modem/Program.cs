using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modem
{
    class Program
    {
        static void Main(string[] args)
        {
            // 	    Modem myModem = new Modem();
            //   myModem.send();

            ModemImplementation myModem = new ModemImplementation();
            myModem.send();
        }

        // class Modem
        // {
        //   public void send() {
        //     Console.WriteLine ("Sending...");
        //   }
        //   public void receive() {
        //         Console.WriteLine ("Receiving...");
        //   }
        //   public void dial() {
        //     Console.WriteLine ("Dialing...");
        //   }
        //   public void hangup() {
        //     Console.WriteLine ("Hanging up...");
        //   }
        // }

        class ModemImplementation : IData, ICommunication
        {
            public void send()
            {
                Console.WriteLine("Sending...");
            }
            public void receive()
            {
                Console.WriteLine("Receiving...");
            }
            public void dial()
            {
                Console.WriteLine("Dialing...");
            }
            public void hangup()
            {
                Console.WriteLine("Hanging up...");
            }
        }
        //Our modem implementation class can choose to implement needed interfaces
        interface IData
        {
            void send();
            void receive();
        }

        interface ICommunication
        {
            void dial();
            void hangup();
        }

    }
}
