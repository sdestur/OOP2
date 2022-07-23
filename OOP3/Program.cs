using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFianaceCredit = new PersonalFianaceCredit();       
            ICreditManager automobileCredit = new AutomobileCredit();
            ICreditManager housingLoanManager = new HousingLoanManager();   
            ICreditManager smallBusinessCredit =new SmallBuisnessCredit();  
            
            ILoggerService databaseLoggerService= new DatabaseLoggerService();  
            ILoggerService fileLoggerService = new FileLoggerService(); 
            ILoggerService smsLoggerService = new SmsLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.DoApplication(smallBusinessCredit,smsLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() {personalFianaceCredit,automobileCredit,housingLoanManager };

            //applicationManager.CreditPreliminaryInformation(credits);
        }
    }
}
