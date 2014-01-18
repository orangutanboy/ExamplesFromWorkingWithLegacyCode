using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Principal;
using System.Threading;

namespace Jobs
{
    public class JobQueue
    {
        private List<Job> _jobs = new List<Job>();
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

        public void Add(Job job)
        {
            _jobs.Add(job);
        }

        public Job Peek(JobType jobType)
        {
            return _jobs.OrderBy(j => j.Priority).Last(j => j.Type == jobType);
        }

        public void Remove(Job job)
        {
            _jobs.Remove(job);
        }
    }
}
