using System;
using System.Collections.Generic;
using System.Text;

namespace cw
{
    class VonWegen
    {
        public bool Arsch { get; set; }
        public string Name { get; set; }

        public void IstArsch(string name)
        {
            this.Name = name;

            Random rnd = new Random();
            int x = rnd.Next(0, 2);

            if (x == 0)
            {
                Arsch = false;
                Console.WriteLine(name + " ist kein Arsch");
            }else
            {
                Arsch = true;
                Console.WriteLine(name + " ist ein Arsch");
            }
        }
    }
}
