using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        //Başvuru durumu
        public void DoApplication(ICreditManager creditManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //    
            creditManager.Calculate();
            loggerService.log();
        }

        public void CreditPreliminaryInformation(List<ICreditManager> credits)
        {

            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
