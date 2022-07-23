using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class PersonalFianaceCredit : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Hesaplandı");
        }

        public void SomethingDo()
        {
            throw new NotImplementedException();
        }
    }
}
