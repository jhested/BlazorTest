namespace MyBlazerServerApp.Data
{
    public class JobHandlerJobService
    {
        public Task<IEnumerable<JobHandlerJob>> GetJobsAsync(string state)
        {
            return Task.Run(() =>
            {
                return Enumerable.Range(1, 3)
                    .Select(x => new JobHandlerJob 
                    { 
                        Id = x, 
                        Name = $"Job {x}", 
                        State = state
                    });
            });
        }

        public Task<IEnumerable<WorkTask>> GetTasksAsync(int jobId)
        {
            return Task.Run(() =>
            {
                return Enumerable.Range(1, 50)
                    .Select(x => new WorkTask
                    {
                        Id = x,
                        Name = $"Job {x}",
                        State = "green"
                    });
            });
        }
    }
}
