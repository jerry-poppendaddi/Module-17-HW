using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Module_17_HW.Profiles;

namespace Module_17_HW
{
    public class RegularAccount : ICalculateInterest 
    {        
        public void Execute(Account account)
        {
            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance >= 1000)
                account.Interest -= account.Balance * 0.4;
        }
    }
}
