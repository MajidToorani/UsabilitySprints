using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsabilitySprints.Models
{
    public class ConvertViewModel
    {
        public int Binary
        {
            get;
            set;
        }
        public int Decimal
        {
            get;
            set;
        }
        public int Result
        {
            get;
            set;
        }
        public int DB(int decimalNumber)
        {
            decimalNumber = 0;
            int binaryNumber = 0;
            int remainder;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                binaryNumber = remainder + binaryNumber;
            }
            return binaryNumber;
        }
        public int BD(int binary)
        {
            throw new NotImplementedException();
        }
    }
}
