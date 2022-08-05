using System;
using System.Collections.Generic;
using System.Text;

namespace OPPS
{
    class Encapsulation
    {
        private int atmPin;
        public int getValue()
        {
            return atmPin;
        }
        public void setValue(int pin)
        {
            atmPin=pin;
        }

    }
}
