using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino_Simulator.Models
{
    public class Die
    {
        private int rolled;
        public int GetFace()
        {
            return rolled;
        }
        public void Roll()
        {
            Random randy = new();
            rolled = randy.Next(1, 7); //MaxValue is exclusive
        }
    }
}
