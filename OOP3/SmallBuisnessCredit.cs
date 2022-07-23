using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class SmallBuisnessCredit: ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf Kredisi Hesaplandı");
        }

        public void SomethingDo()
        {
            throw new NotImplementedException();
        }
    }
}
