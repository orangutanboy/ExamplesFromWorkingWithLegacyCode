using System;

namespace Jobs
{
    public class ReconciliationsJob : Job
    {
        public ReconciliationsJob()
        {
            Type = JobType.Reconciliations;
            Id = Guid.NewGuid();
        }

        public override void Execute()
        {
            #region Implementation Detail
            #endregion
        }
    }
}
