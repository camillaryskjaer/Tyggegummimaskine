using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyggegummimaskine
{
    class Program
    {
        static void Main(string[] args)
        {
            Machine machine = Machine.Instance;

            machine.Fill();
            
            Console.WriteLine("");
            while (machine.bubblegumsred.Length > 0 || machine.bubblegumsorange.Length > 0 || machine.bubblegumsyellow.Length > 0 || 
                   machine.bubblegumspurple.Length > 0 || machine.bubblegumsblue.Length > 0 || machine.bubblegumsgreen.Length > 0)
            {
                Console.WriteLine(machine.Dispense());
                Console.ReadLine();
            }
            
            Console.WriteLine("Theres no more bubblecum");         
            Console.ReadLine();
            
        }
    }
}
