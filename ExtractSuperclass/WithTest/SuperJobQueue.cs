using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobs
{
    public class SuperJobQueue
    {
        protected List<Job> _jobs = new List<Job>();

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
