using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Work_2_Enrique
{
    public class States
    {

        private byte state;

        public States()
        {
            this.state = 1;
        }

        public void ChangeForm(byte state)
        {
            this.state = state;
        }

        public byte GetStates()
        {
            return this.state;
        }
    }
}
