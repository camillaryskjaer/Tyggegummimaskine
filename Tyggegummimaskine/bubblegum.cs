using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyggegummimaskine
{
    public class Bubblegum
    {
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Bubblegum(string color)
        {
            this.Color = color;
        }
    }
}
