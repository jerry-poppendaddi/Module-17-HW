using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_17_HW.Profiles;

namespace Module_17_HW
{
    class Calculator
    {        
        public void CalculateInterest(ICalculateInterest calculateInterest, Account account)
        {
            calculateInterest.Execute(account);
        }
    }
}
