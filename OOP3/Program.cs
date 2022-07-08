using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            ICreditManager microCreditManager = new MicroCreditManager();

            ICreditManager gTKCreditManager = new GTKCreditManager();

            RegisterManager register = new RegisterManager();
            register.Register(new MicroCreditManager(), new DataBaseLoggerService());

            List<ICreditManager> credits = new List<ICreditManager>() { microCreditManager, gTKCreditManager};
            register.GiveInformationAboutCredit(credits);
        }
    }
}
