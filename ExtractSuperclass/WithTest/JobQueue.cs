using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Principal;
using System.Threading;

namespace Jobs
{
    public class JobQueue : SuperJobQueue
    {
        private static JobQueue _instance;
        
        public static JobQueue GetInstance()
        {
            if (_instance == null)
            {
                AppDomain ad = Thread.GetDomain();
                ad.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
                WindowsPrincipal user = Thread.CurrentPrincipal as WindowsPrincipal;

                if (user == null || !user.IsInRole(WindowsBuiltInRole.Administrator))
                {
                    throw new SecurityException("You are not authorised to perform this function");
                }
                _instance = new JobQueue();
            }
            return _instance;
        }

        private JobQueue()
        {
        }
    }
}
