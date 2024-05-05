using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_17_HW.Profiles;

namespace Module_17_HW
{
    public class SalaryAccount : ICalculateInterest
    {
        public void Execute(Account account)
        {
            account.Interest = account.Balance * 0.5;
        }
    }
}

