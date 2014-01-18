using System;

namespace Jobs
{
    public enum JobType
    {
        Unknown,
        DatabaseCleanup,
        Report,
        Reconciliations
    }

    public abstract class Job
    {
        public abstract void Execute();

        public JobType Type { get; protected set; }
        public int Priority { get; set; }
        public Guid Id { get; protected set; }
    }
}
