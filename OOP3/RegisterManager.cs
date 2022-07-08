using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class RegisterManager
    {
        // Method injection
        public void Register (ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log();
        }

        public void GiveInformationAboutCredit(List<ICreditManager> credits)
        {
            foreach (var item in credits)
            {
                item.Calculate();
            }
        }
    }
}
