using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyggegummimaskine
{
    //HVOR ER DIN KODEKOMMENTAR
    
    //Hvorfor sealed?
    public sealed 
        
        
        class Machine
    {
        private static Machine instance = null;
        private static readonly object padlock = new object();

            //Denne skal angives som private...ellers kan alle klasser der ligger i samme namespace også bruge konstruktøren og instantiere
        Machine()
        {
        }
        public static Machine Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Machine();
                    }
                    return instance;
                }
            }
        }

        public Bubblegum[] bubblegumsred = new Bubblegum[7];
        public Bubblegum[] bubblegumsorange = new Bubblegum[10];
        public Bubblegum[] bubblegumsyellow = new Bubblegum[11];
        public Bubblegum[] bubblegumspurple = new Bubblegum[7];
        public Bubblegum[] bubblegumsblue = new Bubblegum[14];
        public Bubblegum[] bubblegumsgreen = new Bubblegum[6];

        
        public void Fill()
        {
            for (int i = 0; i < bubblegumsred.Length; i++)
            {
                bubblegumsred[i] = new Bubblegum("Red");
            }

            for (int i = 0; i < bubblegumsorange.Length; i++)
            {
                bubblegumsorange[i] = new Bubblegum("Orange");
            }

            for (int i = 0; i < bubblegumsyellow.Length; i++)
            {
                bubblegumsyellow[i] = new Bubblegum("Yellow");
            }

            for (int i = 0; i < bubblegumspurple.Length; i++)
            {
                bubblegumspurple[i] = new Bubblegum("Purple");
            }

            for (int i = 0; i < bubblegumsblue.Length; i++)
            {
                bubblegumsblue[i] = new Bubblegum("Blue");
            }

            for (int i = 0; i < bubblegumsgreen.Length; i++)
            {
                bubblegumsgreen[i] = new Bubblegum("Green");
            }
        }
            
            //Hvorfor får det stakkels barn aldrig sit tyggegummi, i stedet får han bare en lille seddel med en besked om at han får et tyggegummi
        public string Dispense()
        {
            Random random = new Random();
            int randoms = random.Next(1, 7);

            switch (randoms)
            {
                case 1:
                    if (bubblegumsred.Length <= 0)
                    {
                        return "Nothing came out, try to turn the nodge again!";
                    }
                    else
                    {
                        bubblegumsred = bubblegumsred.Where(w => w != bubblegumsred[0]).ToArray();
                        return "You got a red bubblegum!";
                    }
                case 2:
                    if (bubblegumsorange.Length <= 0)
                    {
                        return "Nothing came out, try to turn the nodge again!";
                    }
                    else
                    {
                        bubblegumsorange = bubblegumsorange.Where(w => w != bubblegumsorange[0]).ToArray();
                        return "You got a orange bubblegum!";
                    }
                case 3:
                    if (bubblegumsyellow.Length <= 0)
                    {
                        return "Nothing came out, try to turn the nodge again!";
                    }
                    else
                    {
                        bubblegumsyellow = bubblegumsyellow.Where(w => w != bubblegumsyellow[0]).ToArray();
                        return "You got a yellow bubblegum!";
                    }
                case 4:
                    if (bubblegumspurple.Length <= 0)
                    {
                        return "Nothing came out, try to turn the nodge again!";
                    }
                    else
                    {
                        bubblegumspurple = bubblegumspurple.Where(w => w != bubblegumspurple[0]).ToArray();
                        return "You got a purple bubblegum!";
                    }
                case 5:
                    if (bubblegumsblue.Length <= 0)
                    {
                        return "Nothing came out, try to turn the nodge again!";
                    }
                    else
                    {
                        bubblegumsblue = bubblegumsblue.Where(w => w != bubblegumsblue[0]).ToArray();
                        return "You got a blue bubblegum!";
                    }
                case 6:
                    if (bubblegumsgreen.Length <= 0)
                    {
                        return "Nothing came out, try to turn the nodge again!";
                    }
                    else
                    {
                        bubblegumsgreen = bubblegumsgreen.Where(w => w != bubblegumsgreen[0]).ToArray();
                        return "You got a green bubblegum!";
                    }

            }
            return "You broke the machine!";
        }
        
    }

}




