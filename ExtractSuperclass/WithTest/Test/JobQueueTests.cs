using NUnit.Framework;

namespace Jobs.Test
{
    [TestFixture]
    public class JobQueueTests
    {
        [Test]
        public void Test()
        {
            var jobqueue = new SuperJobQueue();
            jobqueue.Add(new ReconciliationsJob());
            jobqueue.Peek(JobType.Reconciliations);
        }
    }
}
